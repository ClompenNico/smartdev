using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using NMCT.Resto.Core.ViewModels;
using NMCT.Resto.iOS.Converters;

namespace NMCT.Resto.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TabInfoView : MvxViewController
    {
        public TabInfoView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            MvxFluentBindingDescriptionSet<TabInfoView, TabInfoViewModel> set =
                this.CreateBindingSet<TabInfoView, TabInfoViewModel>();

            set.Bind(imgRestaurant)                         //control to bind
                .For(img => img.Image)                      //target property
                .To(vm => vm.RestaurantContent.ImageUrl)    //Source property
                .WithConversion<StringToImageConverter>();  //converter to use

            set.Bind(lblName).To(vm => vm.RestaurantContent.Name);
            set.Bind(lblCuisines).To(vm => vm.RestaurantContent.Cuisines);
            //set.Bind(lblScore).To(vm => vm.RestaurantContent.Score);

            set.Bind(lblScore)                               //control to bind
                .For(lbl => lbl.BackgroundColor)            //target property
                .To(vm => vm.RestaurantContent.Score)       //source property
                .WithConversion<ScoreToColorConverter>();   //converter to use

            set.Bind(lblAddress).To(vm => vm.RestaurantContent.Location);
            set.Bind(lblPriceRange).To(vm => vm.RestaurantContent.PriceRangeString);

            set.Apply();

        }
    }
}