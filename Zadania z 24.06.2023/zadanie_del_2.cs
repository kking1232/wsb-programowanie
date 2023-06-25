using System;

public class LineSegment
{
    public static double CalculateLength(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return length;
    }

    public static void Main()
    {
        double x1 = 1.0;
        double y1 = 2.0;
        double x2 = 4.0;
        double y2 = 6.0;

        double segmentLength = CalculateLength(x1, y1, x2, y2);
        Console.WriteLine($"Długość odcinka: {segmentLength}");
    }
}
