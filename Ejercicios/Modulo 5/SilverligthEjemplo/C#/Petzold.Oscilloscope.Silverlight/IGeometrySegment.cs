// Adapted from "Programming Windows Phone 7," XNA part, "Dynamic Textures" chapter, "Geometry of Line Drawing" section
using System.Collections.Generic;

namespace Petzold.Oscilloscope
{
    public interface IGeometrySegment
    {
        void GetAllX(double y, IList<double> xCollection);
    }
}
