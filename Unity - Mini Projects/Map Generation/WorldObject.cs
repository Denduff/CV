using System;

public enum Type
{
    Grass = 0,
    Water = 1,
    Rock = 2
}

public class WorldObject
{
    public Type Type { get; set; }
    public int X { get; set; }
    public int Z { get; set; }

    public WorldObject(Type type, int x, int z)
    {
        Type = type;
        X = x;
        Z = z;
    }

    public static Type GetType(string value)
    {
        value = value[..1].ToUpper() + value[1..];

        return Enum.IsDefined(typeof(Type), value) ? Enum.Parse<Type>(value) : default;
    }

    public static Type GetType(int value)
    {
        return Enum.IsDefined(typeof(Type), value) ? (Type)value : default;
    }
}