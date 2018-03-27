using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Resto.Core.ViewModels;
using System;
using UIKit;

namespace Resto.IOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TabReviewView : MvxViewController<TabReviewViewModel>
    {
        public TabReviewView(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            MvxFluentBindingDescriptionSet<TabReviewView, TabReviewViewModel> set = this.CreateBindingSet<TabReviewView, TabReviewViewModel>();

            set.Bind(txtUsername).To(vm => vm.NewReview.UserName);
            set.Bind(txtScore).To(vm => vm.NewReview.Score);
            set.Bind(txtComments).To(vm => vm.NewReview.Comment);
            set.Bind(pickerDateTime).To(vm => vm.NewReview.DateOfVisit);
            set.Bind(btnSave).To(vm => vm.SaveReviewCommand);
            set.Apply();
        }
    }
}