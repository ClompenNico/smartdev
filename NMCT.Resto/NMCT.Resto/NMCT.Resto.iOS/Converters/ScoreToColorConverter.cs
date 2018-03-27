using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Platform.Converters;
using UIKit;

namespace NMCT.Resto.iOS.Converters
{
    public class ScoreToColorConverter : MvxValueConverter<double, UIColor>
    {
        protected override UIColor Convert(double Score, Type targetType, object parameter, CultureInfo culture)
        {
            return GetOnlineColor(Score);
        }

        private UIColor GetOnlineColor(double Score)
        {
            if (Score >= 4)
                return UIColor.Green;
            else if (Score >= 3.5)
            {
                return UIColor.Yellow;
            }

            else
            {
                return UIColor.Red;
            }
        }
    }
}