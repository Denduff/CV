using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Random = UnityEngine.Random;

public static class World
{
    public static List<WorldObject> WorldObjects => _WorldObjects;
    public static string MapSeed => _MapSeed;

    private static List<WorldObject> _WorldObjects = new();
    private static int _Length;
    private static int _Width;
    private static int _WaterOffset;
    private static int _MaxRivers;
    private static int _MinRiverWidth;
    private static int _MaxRiverWidth;
    private static string _MapSeed;
    private static string _InputSeed;
    private static bool _UseCustomSeed;
    private static int _MapSeedInternal;
    private static int _WaterCount;
    private static int _RiverCount;

    //hook these up to gamestate events
    //GameState.StartOfGame += CreateWorld;
    //GameState.EndOfGame += FlushWorldObjects;



    public static void AddWorldObject(Type type, int x, int z) => 
                        _WorldObjects.Add(new(type, x, z));

    public static void AddWorldObject(string type, int x, int z) => 
                        _WorldObjects.Add(new(WorldObject.GetType(type), x, z));

    public static void AddWorldObject(int type, int x, int z) => 
                        _WorldObjects.Add(new(WorldObject.GetType(type), x, z));

    public static void SetMapSize(int length, int width)
    {
        _Length = length;
        _Width = width;
    }

    public static void SetRiverProperties(int waterOffset, int maxRivers, int minRiverWidth, int maxRiverWidth)
    {
        _WaterOffset = waterOffset;
        _MaxRivers = maxRivers;
        _MinRiverWidth = minRiverWidth;
        _MaxRiverWidth = maxRiverWidth;
    }

    public static void SetInputSeed(string inputSeed, bool useCustomSeed)
    {
        _UseCustomSeed = useCustomSeed;

        if(_UseCustomSeed)
        {
            _InputSeed = inputSeed;
        }
    }

    private static void FlushWorldObjects() => _WorldObjects.Clear();

    public static void CreateWorldTest() =>
#if UNITY_EDITOR
        CreateWorld();
#endif


    private static void CreateWorld()
    {
        if(_UseCustomSeed && Regex.IsMatch(_InputSeed, "[0-9]+"))
        {
            bool isNegative = false;

            if (_InputSeed[0] == '-')
            {
                isNegative = true;
            }

            string intSeed = "";

            intSeed = string.Join(intSeed, _InputSeed.Where(char.IsDigit));

            if (intSeed.Length > 0)
            {
                _MapSeedInternal = int.Parse(intSeed);

                if (isNegative)
                {
                    _MapSeedInternal *= -1;
                }
            }
        }
        else
        {
            _MapSeedInternal = Random.Range(int.MinValue, int.MaxValue);
        }

        _MapSeed = _MapSeedInternal.ToString("0000000000");

        Random.InitState(_MapSeedInternal);

        GenerateFirstRow();

        GenerateWorldRows();

        WorldGenerator.Generate(_WorldObjects);
    }
    //Set first row so it can be used as context to generate the rest.
    private static void GenerateFirstRow()
    {
        int _waterOffset = 0 - _WaterOffset;

        int calcMax = _WaterOffset * 2 / _MaxRivers;

        for (int x = 0; x < _Length; x++)
        {
            if (x < _Length - _WaterOffset)
            {
                if (_MaxRivers > _RiverCount && (_waterOffset > Random.Range(0, calcMax) || _WaterCount > 0))
                {
                    if (_WaterCount > 0)
                    {
                        _WaterCount--;
                    }
                    else
                    {
                        _WaterCount = Random.Range(_MinRiverWidth, _MaxRiverWidth + 1);
                    }

                    _waterOffset = 0 - _WaterOffset;

                    AddWorldObject(Type.Water, x, 0);

                    if (_WaterCount == 0)
                    {
                        _RiverCount++;
                    }
                }
                else
                {
                    CreateNoneWater(x, 0);
                }

                _waterOffset++;

                continue;
            }

            CreateNoneWater(x, 0);
        }
    }

    private static void CreateNoneWater(int x, int z)
    {
        int _blockType = Random.Range((int)Type.Water + 1, 10);

        AddWorldObject(_blockType, x, z);
    }
    //Create a row and fill rivers -> then fill rest of row with non river stuff.
    private static void GenerateWorldRows()
    {
        for (int z = 1; z < _Width; z++)
        {
            CreateRiversForZ(z);

            FillWorldRow(z);
        }
    }
    // Get Row above to see if context should be taken into account.
    private static List<WorldObject> GetWOcontext(int z)
    {
        return WorldObjects.Where(s => s.Z == z - 1).ToList();
    }

    private static void FillWorldRow(int z)
    {
        var worldRow = WorldObjects.Where(s => s.Z == z).ToList();

        for (int x = 0; x < _Length; x++)
        {
            var current = worldRow.Where(s => s.Z == z && s.X == x).FirstOrDefault();

            if (current == null)
            {
                CreateNoneWater(x, z);
            }
        }
    }
        //Returns all water  in a given row
    private static List<WorldObject> RiverData(int z)
    {
        return GetWOcontext(z).Where(x => x.Type == Type.Water).ToList();
    }

    private static void CreateRiversForZ(int z)
    {
            // Get all water in a row, if the water is not connected it becomes a river. Multiple non connected waters = multiple rivers
        List<int[]> rivers = GetConsecutiveIntSets(RiverData(z).Select(x => x.X).ToList());

        for (int i = 0; i < rivers.Count; i++)
        {
            int offset = Random.Range(-1, 2);

            for (int j = 0; j < rivers[i].Length; j++)
            {
                AddWorldObject(Type.Water, rivers[i][j] += offset, z);
            }
        }
    }

    //Check to see if there's any neighbour water blocks and whether they're rivers
    private static List<int[]> GetConsecutiveIntSets(List<int> ints)
    {
        List<int[]> sets = new();

        ints.Sort();

        sets.Add(new int[] { ints[0] });
        ints.RemoveAt(0);

        while (ints.Count > 0)
        {
            if (ints[0].CompareTo(sets[^1][^1]) != 1)
            {
                sets.Add(new int[] { ints[0] });
            }
            else
            {
                sets[^1] = sets[^1].Append(ints[0]).ToArray();
            }

            ints.RemoveAt(0);
        }

        return sets;
    }
}