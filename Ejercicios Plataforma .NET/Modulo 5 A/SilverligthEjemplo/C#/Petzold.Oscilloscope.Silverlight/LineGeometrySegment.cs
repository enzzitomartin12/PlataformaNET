// Adapted from "Programming Windows Phone 7," XNA part, "Dynamic Textures" chapter, "Geometry of Line Drawing" section
using System;
using System.Collections.Generic;
using System.Windows;

namespace Petzold.Oscilloscope
{
    public struct LineGeometrySegment : IGeometrySegment
    {
        readonly double a, b;         // as in x = ay + b

        public LineGeometrySegment(Point point1, Point point2) : this()
        {
            Point1 = point1;
            Point2 = point2;

            a = (Point2.X - Point1.X) / (Point2.Y - Point1.Y);
            b = Point1.X - a * Point1.Y;
        }

        public Point Point1 { private set; get; }
        public Point Point2 { private set; get; }

        public void GetAllX(double y, IList<double> xCollection)
        {
            if ((Point2.Y > Point1.Y && y >= Point1.Y && y < Point2.Y) ||
                (Point2.Y < Point1.Y && y <= Point1.Y && y > Point2.Y))
            {
                xCollection.Add(a * y + b);
            }
        }
    }
}
