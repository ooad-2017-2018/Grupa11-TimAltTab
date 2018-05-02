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
    public sealed partial class VjezbaControl : UserControl
    {
        public VjezbaControl()
        {
            this.InitializeComponent();
        }
        public VjezbaControl(VjezbaUProgramu vjezba)
        {
            InitializeComponent();
            nazivVjezbeTextBlock.Text = vjezba.Vjezba.Naziv;
            brojSetovaTextBlock.Text = vjezba.BrojSetova.ToString();
            brojPonavljanjaTextBlock.Text = vjezba.BrojRepova.ToString();
            vrijemeTextBlock.Text = vjezba.Vrijeme.ToString();
        }
    }
}
