using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using NMCT.Resto.Core.Model;
using Resto.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Core.ViewModels
{
    public class RestoTabsViewModel : MvxViewModel
    {
        private Restaurant _restaurantContent;
        public Restaurant RestaurantContent
        {
            get
            {
                return _restaurantContent;
            }
            set
            {
                _restaurantContent = value;
                RaisePropertyChanged(() => RestaurantContent);
            }
        }

        protected readonly IRestoDataService _restoDataService;
        private readonly Lazy<TabInfoViewModel> _tabInfoViewModel;
        public TabInfoViewModel TabInfoVM => _tabInfoViewModel.Value;

        private readonly Lazy<TabReviewViewModel> _tabReviewVieModel;
        public TabReviewViewModel TabReviewVM => _tabReviewVieModel.Value;

        public RestoTabsViewModel(IRestoDataService restoDataService) {
            this._restoDataService = restoDataService;
            GetRestaurantData();
            _tabInfoViewModel = new Lazy<TabInfoViewModel>(Mvx.IocConstruct<TabInfoViewModel>);
            _tabReviewVieModel = new Lazy<TabReviewViewModel>(Mvx.IocConstruct<TabReviewViewModel>);
            TabReviewVM.ParentViewModel = this;
        }

        public async void GetRestaurantData() {
            var restoList = await _restoDataService.GetRestaurants();
            RestaurantContent = restoList[8];
            RestaurantContent.Reviews = await _restoDataService.GetReviews(RestaurantContent.Id);
            RaisePropertyChanged(() => RestaurantContent);

            TabInfoVM.RestaurantContent = this.RestaurantContent;
        }

    }
}
