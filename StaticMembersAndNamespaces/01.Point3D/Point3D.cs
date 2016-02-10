 using System;
 using System.Runtime;

class Point3D
{
    private double x;
    private double y;
    private double z;
    private static readonly string startingPoint;

    public Point3D()
    {
        
    }

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public static string StartingPoint
    {
        get { return "{0, 0, 0}"; }
    }

    public override string ToString()
    {
        return string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z);
    }
}
