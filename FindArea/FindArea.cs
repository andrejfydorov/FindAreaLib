using System;

namespace FindAreaLib
{
    public class FindArea
    {
        double findAreaOfCircle(Circle circle)
        {
            return Math.PI * Math.Pow(circle._Radius, 2);
        }

        double findAreaOfTriangle(Triangle triangle)
        {
            double p = (triangle.A + triangle.B + triangle.C) / 2;
            return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
        }

    }
}
