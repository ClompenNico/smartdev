using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using NMCT.TipCalculator.Core.ViewModels;
using System;

using UIKit;

namespace NMCT.TipCalculator.iOS.Views
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TipView : MvxViewController
    {
        public TipView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            MvxFluentBindingDescriptionSet<TipView, TipViewModel> set = this.CreateBindingSet<TipView, TipViewModel>();

            set.Bind(txtToPay).To(vm => vm.Payed);
            set.Bind(txtProcent).To(vm => vm.Procent);
            set.Bind(txtTip).To(vm => vm.Tip);

            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}