using System;

namespace Petzold.Oscilloscope
{
    public interface IProvideAxisValue
    {
        double GetAxisValue(DateTime dateTime);
    }
}
