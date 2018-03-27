using Foundation;
using MvvmCross.iOS.Views;
using System;
using UIKit;

namespace Resto.IOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class RestosTableView : MvxTableViewController
    {
        public RestosTableView (IntPtr handle) : base (handle)
        {

        }
    }
}