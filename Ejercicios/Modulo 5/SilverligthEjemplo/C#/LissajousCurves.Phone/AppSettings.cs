
namespace LissajousCurves.Phone
{
    public class AppSettings
    {
        public AppSettings()
        {
            XAmplitude = 0.9;
            XFrequency = 2;
            YAmplitude = 0.9;
            YFrequency = 1;
            Brightness = 2;
            Persistence = 4;
        }

        public double XAmplitude { set; get; }

        public double XFrequency { set; get; }

        public double YAmplitude { set; get; }

        public double YFrequency { set; get; }

        public double Brightness { set; get; }

        public double Persistence { set; get; }
    }
}
