using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin_Essentials.ViewModels
{
    class CompassViewModel : BaseViewModel
    {
        string headingDisplay;
        double heading;
        double rotationHeading;

        
        public CompassViewModel()
        {
            Title = "Compass";
            Stop();
            Start();
        }
        public string HeadingDisplay
        {
            get => headingDisplay;
            set => SetProperty(ref headingDisplay, value);
        }

        public double Heading
        {
            get => heading;
            set => SetProperty(ref heading, value);
        }

        public double RotationHeading
        {
            get => rotationHeading;
            set => SetProperty(ref rotationHeading, value);
        }

        void Stop()
        {
            if (!Compass.IsMonitoring)
                return;

            Compass.ReadingChanged -= Compass_ReadingChanged;
            Compass.Stop();
        }
        void Start()
        {
            if (Compass.IsMonitoring)
                return;

            Compass.ReadingChanged += Compass_ReadingChanged;
            Compass.Start(SensorSpeed.UI);

        }

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            Heading = e.Reading.HeadingMagneticNorth;
            HeadingDisplay = $"{Math.Round(Heading)}";
            RotationHeading = 360 - Heading;
        }
    }

}
