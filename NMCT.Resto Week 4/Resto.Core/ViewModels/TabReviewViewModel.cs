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
    public class TabReviewViewModel : MvxViewModel
    {
        protected readonly IRestoDataService _restoDataService;
        private readonly Lazy<TabInfoViewModel> _tabInfoViewModel;
        public TabInfoViewModel TabInfoVM => _tabInfoViewModel.Value;


        public TabReviewViewModel(IRestoDataService restoDataService)
        {
            this._restoDataService = restoDataService;
            _tabInfoViewModel = new Lazy<TabInfoViewModel>(Mvx.IocConstruct<TabInfoViewModel>);
        }

        public RestoTabsViewModel ParentViewModel { get; set; }

        private Review _newReview = new Review();
        public Review NewReview
        {
            get
            {
                return _newReview;
            }
            set
            {
                _newReview = value;
                RaisePropertyChanged(() => NewReview);
            }
        }

        public MvxCommand SaveReviewCommand { get { return new MvxCommand(SaveReview); } }

        private async void SaveReview() {
            try
            {
                bool succes = await _restoDataService.AddReview(ParentViewModel.RestaurantContent.Id, NewReview);
                if (succes) NewReview = new Review();
                ParentViewModel.GetRestaurantData();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
