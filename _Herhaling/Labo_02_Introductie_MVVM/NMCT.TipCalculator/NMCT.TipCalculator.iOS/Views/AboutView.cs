using Foundation;
using MvvmCross.iOS.Views;
using System;
using UIKit;

namespace NMCT.TipCalculator.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class AboutView : MvxViewController
    {
        public AboutView (IntPtr handle) : base (handle)
        {
        }
    }
}