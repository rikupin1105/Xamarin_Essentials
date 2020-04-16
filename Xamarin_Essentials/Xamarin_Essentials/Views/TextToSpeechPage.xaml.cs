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
    public partial class TextToSpeechPage : ContentPage
    {
        public TextToSpeechPage()
        {
            InitializeComponent();
        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await TextToSpeech.SpeakAsync(EntryText.Text, new SpeechOptions
                {
                    Volume = (float)SliderVolume.Value,
                    Pitch = (float)SliderPitch.Value
                });
            }
            catch (Exception)
            {

            }
        }
    }
}