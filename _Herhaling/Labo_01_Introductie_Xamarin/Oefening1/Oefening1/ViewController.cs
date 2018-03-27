using System;

using UIKit;

namespace Oefening1
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BtnHelloWorld_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
            UIAlertView alert = new UIAlertView()
            {
                Title = "Labo 1",
                Message = "Hello Xamarin"
            };
            alert.AddButton("OK");
            alert.Show();
        }
    }
}