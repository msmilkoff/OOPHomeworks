using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Point3D.StartingPoint);
        Console.WriteLine();

        var point_1 = new Point3D(2 ,4 ,6);
        var point_2 = new Point3D(1,6,4);

        double distace = DistanceCalculator.CalculateDistance(point_1, point_2);

        Console.WriteLine(distace);
    }
}
