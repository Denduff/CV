using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public static void Generate(List<WorldObject> worldObjects)
    {
        GameObject[] gameObjects = Resources.LoadAll<GameObject>("Prefabs/Map/");

        foreach (Type type in (Type[])Enum.GetValues(typeof(Type)))
        {
            foreach (WorldObject wo in worldObjects.Where(t => t.Type == type))
            {
                Instantiate(gameObjects.First(go => go.name == wo.Type.ToString()), new(wo.X, 0, wo.Z), Quaternion.identity);
            }
        }
    }
}