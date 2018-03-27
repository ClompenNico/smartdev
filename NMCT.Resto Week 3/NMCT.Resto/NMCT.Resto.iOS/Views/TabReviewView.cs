using Foundation;
using MvvmCross.iOS.Views;
using System;
using UIKit;

namespace NMCT.Resto.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TabReviewView : MvxViewController
    {
        public TabReviewView (IntPtr handle) : base (handle)
        {
            /*public TabReviewView ()
            {
                
            }*/
        }
    }
}