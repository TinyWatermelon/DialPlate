using System;
using Windows.UI;
using System.Numerics;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Graphics.Canvas.Brushes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GraphicTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            
            this.InitializeComponent();
            //for (int i = 0; i < 13; i++)
            //{
            //    Debug.WriteLine((GetPoint(i * 8.333 - 0.5, 197).X) + "," + GetPoint(i * 8.333 - 0.5, 197).Y);
            //    Debug.WriteLine("");
            //    Debug.WriteLine((GetPoint(i * 8.333, 197).X) + "," + GetPoint(i * 8.333, 197).Y);
            //}
        }
        //public Point GetPoint(double percent, double radius)
        //{
        //    double percentRad = percent / 100 * Math.PI;
        //    Point temp = new Point((1 - Math.Cos(percentRad)) * radius + 3, -radius * Math.Sin(percentRad) + 200); 
        //    return temp;
        //}


        //private void BGCycle_Draw(Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl sender, Microsoft.Graphics.Canvas.UI.Xaml.CanvasDrawEventArgs args)
        //{
        //    CanvasGradientStop[] gradientStop = new CanvasGradientStop[2];
        //    gradientStop[0] = new CanvasGradientStop();
        //    gradientStop[0].Color = Color.FromArgb(180, 18, 208, 255);
        //    gradientStop[0].Position = 0f;

        //    gradientStop[1] = new CanvasGradientStop();
        //    gradientStop[1].Color = Color.FromArgb(0, 255, 255, 255);
        //    gradientStop[1].Position = 1f;

        //    CanvasRadialGradientBrush brush = new CanvasRadialGradientBrush(sender, gradientStop);
        //    brush.RadiusX = 200;
        //    brush.RadiusY = 200;
        //    brush.Center = new Vector2(200, 200);

        //    args.DrawingSession.FillCircle(200, 200, 200, brush);

        //}

        //private void page_unloaded(object sender, routedeventargs e)
        //{
        //    this.bgcycle.removefromvisualtree();
        //    this.bgcycle = null;
        //}
    }
    public class SliderValueToPoint : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return GetPoint((double)value, 202);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
        public Point GetPoint(double percent, double radius = 202)
        {
            double percentRad = percent / 100 * Math.PI;
            Point temp = new Point((1 - Math.Cos(percentRad)) * radius + 200 - radius, -radius * Math.Sin(percentRad) + 200);                //Math.Cos和Math.sin传入的值是弧度制的，传角度不行，别问我怎么知道的，我不会说我调试了半个小时才找到错在哪
            return temp;
        }
    }
    public class SliderValueToPoint2 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return GetPoint((double)value, 205);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
        public Point GetPoint(double percent, double radius = 205)
        {
            double percentRad = percent / 100 * Math.PI;
            Point temp = new Point((1 - Math.Cos(percentRad)) * radius + 200 - radius, -radius * Math.Sin(percentRad) + 200);                //Math.Cos和Math.sin传入的值是弧度制的，传角度不行，别问我怎么知道的，我不会说我调试了半个小时才找到错在哪
            return temp;
        }
    }
}
