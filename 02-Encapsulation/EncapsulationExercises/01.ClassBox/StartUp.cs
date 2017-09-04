using System;
using System.Linq;
using System.Reflection;
public class Program
{
    static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        var input = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        Console.WriteLine($"Surface Area - {input.GetSurfaceArea():F2}");
        Console.WriteLine($"Lateral Surface Area - {input.GetLateralSurfaceArea():F2}");
        Console.WriteLine($"Volume - {input.GetVolume():F2}");
    }
}

