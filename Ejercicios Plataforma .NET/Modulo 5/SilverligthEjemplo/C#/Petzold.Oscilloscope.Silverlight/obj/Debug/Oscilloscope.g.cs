﻿#pragma checksum "C:\Users\Victor\Desktop\Ejemplos\Modulo 5\SilverlitgthEjemplo\C#\Petzold.Oscilloscope.Silverlight\Oscilloscope.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6F40402CD9593148CA8F6DDB0FCD00BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.269
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Petzold.Oscilloscope {
    
    
    public partial class Oscilloscope : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid lineGrid;
        
        internal System.Windows.Controls.Image screenImage;
        
        internal System.Windows.Controls.Canvas screenCanvas;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Petzold.Oscilloscope.Silverlight;component/Oscilloscope.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lineGrid = ((System.Windows.Controls.Grid)(this.FindName("lineGrid")));
            this.screenImage = ((System.Windows.Controls.Image)(this.FindName("screenImage")));
            this.screenCanvas = ((System.Windows.Controls.Canvas)(this.FindName("screenCanvas")));
        }
    }
}
