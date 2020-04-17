using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Xamarin_Essentials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VibrationPage : ContentPage
    {
        public VibrationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var duration = TimeSpan.FromSeconds(SliderDuration.Value);
                Vibration.Vibrate(duration);
            }
            catch (Exception)
            {

            }
        }
    }
}