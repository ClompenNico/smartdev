using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;

namespace TipCalculator
{
    public class MyViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.Yellow;

            //=== TEXTFIELD ===

            UITextField totalAmount = new UITextField(
                    new CGRect(20, 28, View.Bounds.Width - 40, 35))
            {
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Total Amount"
            };

            //=== BUTTON ===

            UIButton calcButton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CGRect(20, 71, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.FromRGB(0, 0.5f, 0),
            };
            calcButton.SetTitle("Calculate", UIControlState.Normal);

            //=== RESULT ===

            UILabel resultLabel = new UILabel(new CGRect(20, 124, View.Bounds.Width - 40, 40))
            {
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(24),
                Text = "Tip is $0.00"
            };

            //=== ADDING CHILDS===

            UISegmentedControl tipAmount = new UISegmentedControl(new CGRect(20, 172, View.Bounds.Width - 40, 40));
                tipAmount.InsertSegment("10%", 0, false);
                tipAmount.InsertSegment("15%", 1, false);
                tipAmount.InsertSegment("20%", 2, false);
                tipAmount.InsertSegment("25%", 3, false);

                //STANDAARD GESELECTEERDE SEGMENT
                tipAmount.SelectedSegment = 2;

            //VIEW TOEVOEGEN (WAT JE ZIET UITEINDELIJK)
            View.AddSubviews(new UIView[] { totalAmount, calcButton, tipAmount, resultLabel });

            //=== ADDING LOGIC===
            calcButton.TouchUpInside += (s, e) =>
            {
                //TOETSENBORD WEG
                totalAmount.ResignFirstResponder();

                //TIP BEREKENING
                double tip = (tipAmount.SelectedSegment * 5) + 10;

                //BEREKENING
                double value = 0;
                Double.TryParse(totalAmount.Text, out value);
                resultLabel.Text = string.Format("Tip is {0:C}", TipCalculator.GetTip(value, tip));
            };
        }
    }
}