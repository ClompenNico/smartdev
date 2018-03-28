// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace NMCT.TipCalculator.iOS.Views
{
    [Register ("TipView")]
    partial class TipView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAboutScreen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtProcent { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel txtTip { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtToPay { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnAboutScreen != null) {
                btnAboutScreen.Dispose ();
                btnAboutScreen = null;
            }

            if (txtProcent != null) {
                txtProcent.Dispose ();
                txtProcent = null;
            }

            if (txtTip != null) {
                txtTip.Dispose ();
                txtTip = null;
            }

            if (txtToPay != null) {
                txtToPay.Dispose ();
                txtToPay = null;
            }
        }
    }
}