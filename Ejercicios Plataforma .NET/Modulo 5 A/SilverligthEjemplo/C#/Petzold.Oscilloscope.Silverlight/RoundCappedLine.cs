// Adapted from "Programming Windows Phone 7," XNA part, "Dynamic Textures" chapter, "Geometry of Line Drawing" section
using System;
using System.Collections.Generic;
using System.Windows;

namespace Petzold.Oscilloscope
{
    public struct RoundCappedLine : IGeometrySegment
    {
        LineGeometrySegment lineSegment1;
        ArcGeometrySegment arcSegment1;
        LineGeometrySegment lineSegment2;
        ArcGeometrySegment arcSegment2;

        public RoundCappedLine(Point point1, Point point2, double radius) : this()
        {
            Point1 = point1;
            Point2 = point2;
            Radius = radius;

            Point vector = new Point(point2.X - point1.X, point2.Y - point1.Y);
            double length = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            Point normVect = new Point(vector.X / length, vector.Y / length);

            Point pt1a = new Point(point1.X + radius * normVect.Y, point1.Y - radius * normVect.X);
            Point pt2a = new Point(pt1a.X + vector.X, pt1a.Y + vector.Y);
            Point pt1b = new Point(point1.X - radius * normVect.Y, point1.Y + radius * normVect.X);
            Point pt2b = new Point(pt1b.X + vector.X, pt1b.Y + vector.Y);

            lineSegment1 = new LineGeometrySegment(pt1a, pt2a);
            arcSegment1 = new ArcGeometrySegment(point2, radius, pt2a, pt2b);
            lineSegment2 = new LineGeometrySegment(pt2b, pt1b);
            arcSegment2 = new ArcGeometrySegment(point1, radius, pt1b, pt1a);
        }

        public Point Point1 { private set; get; }
        public Point Point2 { private set; get; }
        public double Radius { private set; get; }

        public void GetAllX(double y, IList<double> xCollection)
        {
            int count = xCollection.Count;

            arcSegment1.GetAllX(y, xCollection);
            lineSegment1.GetAllX(y, xCollection);
            arcSegment2.GetAllX(y, xCollection);
            lineSegment2.GetAllX(y, xCollection);

            // Ensure collection has pairs of points
            if (xCollection.Count == count + 1)
                xCollection.Add(xCollection[xCollection.Count - 1]);
        }
    }
}
