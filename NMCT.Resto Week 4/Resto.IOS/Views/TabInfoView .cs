using Resto.Core.ViewModels;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;
using UIKit;
using Resto.IOS.Converters;

namespace Resto.IOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TabInfoView : MvxViewController<TabInfoViewModel>
    {
        public TabInfoView(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            MvxFluentBindingDescriptionSet<TabInfoView, TabInfoViewModel> set = this.CreateBindingSet<TabInfoView, TabInfoViewModel>();

            set.Bind(lblCuisine).To(vm => vm.RestaurantContent.Cuisines);
            set.Bind(lblName).To(vm => vm.RestaurantContent.Name); 
            set.Bind(lblScore).To(vm => vm.RestaurantContent.Score);
            set.Bind(lblPriceRange).To(vm => vm.RestaurantContent.PriceRangeSymb);
            set.Bind(lblAddress).To(vm => vm.RestaurantContent.Location);
            set.Bind(imgRestaurant).For(img => img.Image).To(vm => vm.RestaurantContent.ImageUrl).WithConversion<StringToImageConverter>();
            set.Bind(lblScore).For(color => color.BackgroundColor).To(vm => vm.RestaurantContent.Score).WithConversion<ScoreToColorConverter>();
            set.Apply();
        }   
    }
}