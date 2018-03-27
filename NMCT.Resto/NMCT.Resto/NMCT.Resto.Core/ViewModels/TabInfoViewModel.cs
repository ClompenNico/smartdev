using System;
using MvvmCross.Core.ViewModels;
using NMCT.Resto.Core.Model;
using NMCT.Resto.Core.Services;

namespace NMCT.Resto.Core.ViewModels
{
    public class TabInfoViewModel : MvxViewModel
    {
        //Begin NAME -------
        private string _name = "nmct";
        public string Name
        {
            get {
                return _name;
            }
            set {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        //End NAME ********

        //Begin Restaurant -------
        private Restaurant _restaurantContent;
        public Restaurant RestaurantContent
        {
            get { return _restaurantContent; }
            set {
                _restaurantContent = value; 
                RaisePropertyChanged(() => RestaurantContent);
            
            }
        }
        //End Restaurant ********

        protected readonly IRestoDataService _restoDataService;

        public TabInfoViewModel(IRestoDataService restoDataService)
        {
            this._restoDataService = restoDataService;
            ChooseRandomRestaurant();
        }

        private async void ChooseRandomRestaurant()
        {
            RestaurantContent = await _restoDataService.GetRandomRestaurant();
            RestaurantContent.Reviews = await _restoDataService.GetReviews(RestaurantContent.Id);
            RaisePropertyChanged(() => RestaurantContent);
        }

    }
}
