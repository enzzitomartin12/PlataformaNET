// Adapted from "Programming Windows Phone 7," XNA part, "Dynamic Textures" chapter, "Geometry of Line Drawing" section
using System;
using System.Collections.Generic;
using System.Windows;

namespace Petzold.Oscilloscope
{
    public struct ArcGeometrySegment : IGeometrySegment
    {
        readonly double angle1, angle2;

        public ArcGeometrySegment(Point center, double radius, 
                                  Point point1, Point point2) : 
            this()
        {
            Center = center;
            Radius = radius;
            Point1 = point1;
            Point2 = point2;
            angle1 = Math.Atan2(point1.Y - center.Y, point1.X - center.X);
            angle2 = Math.Atan2(point2.Y - center.Y, point2.X - center.X);
        }

        public Point Center { private set; get; }
        public double Radius { private set; get; }
        public Point Point1 { private set; get; }
        public Point Point2 { private set; get; }

        public void GetAllX(double y, IList<double> xCollection)
        {
            // Quick check that we're in the ballpark
            if (Math.Abs(y - Center.Y) > Radius)
                return;

            double sqrtArg = Radius * Radius - (y - Center.Y) * (y - Center.Y);

            if (sqrtArg >= 0)
            {
                double sqrt = Math.Sqrt(sqrtArg);
                TryY(y, Center.X + sqrt, xCollection);
                TryY(y, Center.X - sqrt, xCollection);
            }
        }

        public void TryY(double y, double x, IList<double> xCollection)
        {
            double angle = Math.Atan2(y - Center.Y, x - Center.X);

            if ((angle1 < angle2 && (angle1 <= angle && angle < angle2)) ||
                (angle1 > angle2 && (angle1 <= angle || angle < angle2)))
            {
                xCollection.Add(x);
            }
        }
    }
}
