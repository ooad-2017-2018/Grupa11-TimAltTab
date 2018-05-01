using System;
using System.Collections.Generic;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace BeFit
{
    public sealed partial class PodaciControl : UserControl
    {
        public string Naziv
        {
            get { return nazivTextBlock.Text; }
            set { nazivTextBlock.Text = value; }
        }
        public string Podatak
        {
            get { return podatakTextBox.Text; }
            set { podatakTextBox.Text = value; }
        }
        public PodaciControl()
        {
            this.InitializeComponent();
            Podatak = "";
        }
        public PodaciControl(string naziv, string podatak)
        {
            this.InitializeComponent();
            Naziv = naziv;
            Podatak = podatak;
        }
    }
}
