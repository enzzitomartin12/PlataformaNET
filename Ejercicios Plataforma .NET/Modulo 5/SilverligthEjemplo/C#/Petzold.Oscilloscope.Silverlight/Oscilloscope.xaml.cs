// These four mutually-exclusive defines govern how the lines are rendered
// -----------------------------------------------------------------------

// #define USE_WRITEABLEBITMAP_WITH_POLYLINE
// #define USE_WRITEABLEBITMAP_WITH_OUTLINE_FILL
#define USE_CANVAS_WITH_ANIMATION_FADEOUT
// #define USE_CANVAS_WITH_MANUAL_FADEOUT

#if USE_WRITEABLEBITMAP_WITH_POLYLINE || USE_WRITEABLEBITMAP_WITH_OUTLINE_FILL
#define USE_WRITEABLEBITMAP
#endif

#if USE_CANVAS_WITH_ANIMATION_FADEOUT || USE_CANVAS_WITH_MANUAL_FADEOUT
#define USE_CANVAS
#endif

#if USE_WRITEABLEBITMAP && USE_CANVAS
#error Only one of four rendering symbols in Oscilloscope.xaml.cs can be defined!
#endif

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Petzold.Oscilloscope
{
    public partial class Oscilloscope : UserControl
    {
        DateTime lastDateTime = DateTime.Now;

#if USE_WRITEABLEBITMAP

        WriteableBitmap writeableBitmap;

#endif // USE_WRITEABLEBITMAP

#if USE_WRITEABLEBITMAP_WITH_OUTLINE_FILL

        const int beamPixel = unchecked((int)0xFF00FF00);
        PointCollection points = new PointCollection();
        List<RoundCappedLine> lineList = new List<RoundCappedLine>();
        List<double> xCollection = new List<double>();

#else
        SolidColorBrush strokeBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0, 0xFF, 0));
#endif

#if !USE_CANVAS_WITH_ANIMATION_FADEOUT

        double accumulatedDecrease;

#endif // !USE_CANVAS_WITH_ANIMATION_FADEOUT

#if USE_CANVAS_WITH_MANUAL_FADEOUT

        List<UIElement> removableElements = new List<UIElement>();

#endif // USE CANVAS_WITH_MANUAL_FADEOUT

        public static readonly DependencyProperty XProviderProperty =
            DependencyProperty.Register("XProvider",
                typeof(IProvideAxisValue),
                typeof(Oscilloscope),
                new PropertyMetadata(null));

        public static readonly DependencyProperty YProviderProperty =
            DependencyProperty.Register("YProvider",
                typeof(IProvideAxisValue),
                typeof(Oscilloscope),
                new PropertyMetadata(null));

        public static readonly DependencyProperty BrightnessProperty =
            DependencyProperty.Register("Brightness",
                typeof(double),
                typeof(Oscilloscope),
                new PropertyMetadata(2.0));

        public static readonly DependencyProperty PersistenceProperty =
            DependencyProperty.Register("Persistence",
                typeof(double),
                typeof(Oscilloscope),
                new PropertyMetadata(4.0));

#if USE_CANVAS_WITH_ANIMATION_FADEOUT

        public static readonly DependencyProperty AnimatedObjectProperty =
            DependencyProperty.RegisterAttached("AnimatedObject",
                typeof(FrameworkElement),
                typeof(Oscilloscope),
                new PropertyMetadata(null));

#endif // USE_CANVAS_WITH_ANIMATION_FADEOUT

        public Oscilloscope()
        {
            InitializeComponent();
        }

        public IProvideAxisValue XProvider
        {
            set { SetValue(XProviderProperty, value); }
            get { return (IProvideAxisValue)GetValue(XProviderProperty); }
        }

        public IProvideAxisValue YProvider
        {
            set { SetValue(YProviderProperty, value); }
            get { return (IProvideAxisValue)GetValue(YProviderProperty); }
        }

        public double Brightness
        {
            set { SetValue(BrightnessProperty, value); }
            get { return (double)GetValue(BrightnessProperty); }
        }

        public double Persistence
        {
            set { SetValue(PersistenceProperty, value); }
            get { return (double)GetValue(PersistenceProperty); }
        }

        void OnLayoutRootSizeChanged(object sender, SizeChangedEventArgs args)
        {
            if (!args.NewSize.IsEmpty)
            {
                lineGrid.Children.Clear();
                SolidColorBrush grayBrush = new SolidColorBrush(Colors.LightGray);

                // Display vertical grid lines
                for (double x = 0; x <= args.NewSize.Width; x += args.NewSize.Width / 10)
                {
                    Line line = new Line
                    {
                        X1 = x,
                        Y1 = 0,
                        X2 = x,
                        Y2 = args.NewSize.Height,
                        Stroke = grayBrush,
                        StrokeThickness = (x == args.NewSize.Width / 2) ? 2 : 1
                    };
                    lineGrid.Children.Add(line);
                }

                // Display horizontal grid lines
                for (double y = 0; y <= args.NewSize.Height; y += args.NewSize.Height / 8)
                {
                    Line line = new Line
                    {
                        X1 = 0,
                        Y1 = y,
                        X2 = args.NewSize.Width,
                        Y2 = y,
                        Stroke = grayBrush,
                        StrokeThickness = (y == args.NewSize.Height / 2) ? 2 : 1
                    };

                    lineGrid.Children.Add(line);
                }

#if USE_WRITEABLEBITMAP

                // Create WriteableBitmap
                writeableBitmap = new WriteableBitmap((int)args.NewSize.Width, (int)args.NewSize.Height);
                screenImage.Source = writeableBitmap;
                screenImage.Visibility = Visibility.Visible;
                screenCanvas.Visibility = Visibility.Collapsed;

#endif // USE_WRITEABLEBITMAP

                // Start up the Rendering event
                CompositionTarget.Rendering += OnCompositionTargetRendering;
            }
            else
            {
                CompositionTarget.Rendering -= OnCompositionTargetRendering;
            }
        }

        void OnCompositionTargetRendering(object sender, EventArgs args)
        {
            DateTime dateTime = DateTime.Now;

#if !USE_CANVAS_WITH_ANIMATION_FADEOUT

            // Determine the amount to decrease the intensity of each pixel
            accumulatedDecrease += 256 * (dateTime - lastDateTime).TotalSeconds / Persistence;
            int decrease = (int)accumulatedDecrease;

            // If integral decrease, sweep through the pixels
            if (decrease > 0)
            {
                accumulatedDecrease -= decrease;

            #if USE_WRITEABLEBITMAP

                for (int index = 0; index < writeableBitmap.Pixels.Length; index++)
                {
                    int pixel = writeableBitmap.Pixels[index];

                    if (pixel != 0)
                    {
                        int a = pixel >> 24 & 0xFF;
                        int r = pixel >> 16 & 0xFF;
                        int g = pixel >> 8 & 0xFF;
                        int b = pixel & 0xFF;

                        a = Math.Max(0, a - decrease);
                        r = Math.Max(0, r - decrease);
                        g = Math.Max(0, g - decrease);
                        b = Math.Max(0, b - decrease);

                        writeableBitmap.Pixels[index] = a << 24 | r << 16 | g << 8 | b;
                    }
                }

            #elif USE_CANVAS_WITH_MANUAL_FADEOUT

                // Decrease the color of each element
                foreach (UIElement child in screenCanvas.Children)
                {
                    SolidColorBrush brush = (child as Shape).Stroke as SolidColorBrush;
                    Color clr = brush.Color;
                    brush.Color = Color.FromArgb((byte)Math.Max(0, clr.A - decrease), clr.R, clr.G, clr.B);

                    if (brush.Color.A == 0)
                        removableElements.Add(child);
                }

                foreach (UIElement child in removableElements)
                    screenCanvas.Children.Remove(child);
            #endif 
            }
#endif
            if (XProvider != null && YProvider != null)
            {

#if USE_WRITEABLEBITMAP_WITH_OUTLINE_FILL

                points.Clear();
                
#else
                Polyline polyline = new Polyline
                {
                    StrokeThickness = this.Brightness,
                    Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0, 0xFF, 0)),
                    StrokeStartLineCap = PenLineCap.Round,
                    StrokeEndLineCap = PenLineCap.Round,
                    StrokeLineJoin = PenLineJoin.Round
                };

                PointCollection points = polyline.Points;
#endif

                // Interpolate from lastDateTime to current dateTime
                int milliseconds = (int)(dateTime - lastDateTime).TotalMilliseconds;

                for (int msec = 0; msec <= milliseconds; msec++)
                {
                    DateTime dt = lastDateTime + TimeSpan.FromMilliseconds(msec);

                    Point point = new Point(0.5 * LayoutRoot.ActualWidth * (1 + XProvider.GetAxisValue(dt)),
                                            0.5 * LayoutRoot.ActualHeight * (1 + YProvider.GetAxisValue(dt)));
                    points.Add(point);
                }

                lastDateTime = dateTime;         

#if USE_CANVAS_WITH_ANIMATION_FADEOUT

                ColorAnimation anima = new ColorAnimation
                {
                    To = Color.FromArgb(0, 0, 0xFF, 0),
                    Duration = TimeSpan.FromSeconds(this.Persistence)
                };

                Storyboard.SetTarget(anima, polyline.Stroke as SolidColorBrush);
                Storyboard.SetTargetProperty(anima, new PropertyPath(SolidColorBrush.ColorProperty));

                Storyboard storyboard = new Storyboard();
                storyboard.SetValue(Oscilloscope.AnimatedObjectProperty, polyline);
                storyboard.Children.Add(anima);
                storyboard.Completed += new EventHandler(storyboard_Completed);
                storyboard.Begin();
#endif

#if USE_CANVAS

                screenCanvas.Children.Add(polyline);

#elif USE_WRITEABLEBITMAP_WITH_POLYLINE

                writeableBitmap.Render(polyline, null);

#else // USE_WRITEABLEBITMAP_WITH_OUTLINE_FILL

                lineList.Clear();

                for (int i = 0; i < points.Count - 1; i++)
                {
                    RoundCappedLine line = new RoundCappedLine(points[i], points[i + 1], this.Brightness / 2);
                    lineList.Add(line);
                }

                for (int y = 0; y < writeableBitmap.PixelHeight; y++)
                {
                    xCollection.Clear();

                    foreach (RoundCappedLine line in lineList)
                        line.GetAllX(y, xCollection);

                    if (xCollection.Count > 0)
                    {
                        int rowIndex = y * writeableBitmap.PixelWidth;
                                
                        for (int pair = 0; pair < xCollection.Count; pair += 2)
                        {
                            int x1 = (int)xCollection[pair];
                            int x2 = (int)xCollection[pair + 1];

                            if (x1 != x2)
                            {
                                int xMin = Math.Max(0, Math.Min(writeableBitmap.PixelWidth - 1, Math.Min(x1, x2)));
                                int xMax = Math.Max(0, Math.Min(writeableBitmap.PixelWidth - 1, Math.Max(x1, x2)));

                                for (int x = xMin; x < xMax; x++)
                                {
                                    writeableBitmap.Pixels[rowIndex + x] = beamPixel;
                                }
                            }
                        }
                    }
                }
#endif
            }

#if USE_WRITEABLEBITMAP

            writeableBitmap.Invalidate();
#endif
            
        }

#if USE_CANVAS_WITH_ANIMATION_FADEOUT

        void storyboard_Completed(object sender, EventArgs e)
        {
            Storyboard storyboard = sender as Storyboard;
            FrameworkElement animatedObject = storyboard.GetValue(Oscilloscope.AnimatedObjectProperty) as FrameworkElement;
            screenCanvas.Children.Remove(animatedObject);
        }

#endif

    }
}

