using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Essentials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompassPage : ContentPage
    {
        public CompassPage()
        {
            InitializeComponent();
            compassImage.Source = ImageSource.FromResource("Xamarin_Essentials.Image.compass.png");
        }
    }

}