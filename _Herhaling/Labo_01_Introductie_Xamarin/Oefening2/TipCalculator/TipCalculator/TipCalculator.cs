using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace TipCalculator
{
    public class TipCalculator
    {
        public static double GetTip(double amount, double percentage)
        {
            return amount * percentage / 100.0;
        }
    }
}