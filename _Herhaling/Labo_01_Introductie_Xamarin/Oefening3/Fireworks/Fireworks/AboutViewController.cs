using Foundation;
using System;
using UIKit;

namespace Fireworks
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController (IntPtr handle) : base (handle)
        {
        }

        partial void ButtonAbout_TouchUpInside(UIButton sender)
        {
            //TO GO BACK AND CLOSE THIS PAGE
            this.DismissViewController(true, null);
        }
    }
}