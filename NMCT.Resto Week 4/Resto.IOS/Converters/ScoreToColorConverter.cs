using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Platform.Converters;
using UIKit;

namespace Resto.IOS.Converters
{
    public class ScoreToColorConverter : MvxValueConverter<double, UIColor>
    {
        protected override UIColor Convert(double value, Type targetType, object parameter, CultureInfo culture)
        {
            return GetColor(value);
        }

        private UIColor GetColor(double score)
        {
            if (double.IsNaN(score)) return null;
            if (score <= 1.7)
            {
                return UIColor.Red;
            }
            else if (score > 1.7 && score <= 3.5)
            {
                return UIColor.Orange;
            }
            else if (score > 3.5 && score <= 5)
            {
                return UIColor.Green;
            }
            else {
                return null;
            }
        }
    }
}