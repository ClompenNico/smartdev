using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace NMCT.Resto.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TabInfoViewModel : MvxViewController
    {
        public TabInfoViewModel(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            MvxFluentBindingDescriptionSet<TabInfoView, TabInfoViewModel> set =
                this.CreateBindingSet<TabInfoView, TabInfoViewModel>();

            set.Bind(lblName).To(vm => vm.Name);
            set.Apply();

        }
}
}