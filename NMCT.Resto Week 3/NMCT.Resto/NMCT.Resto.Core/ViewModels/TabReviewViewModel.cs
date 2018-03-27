using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using NMCT.Resto.Core.Services;
using UIKit;

namespace NMCT.Resto.Core.ViewModels
{
    public class TabReviewViewModel : MvxViewModel
    {
        //create a lazy instance for each viewmodel of the tabs in the tabview
        private readonly Lazy<TabInfoViewModel> _tabInfoViewModel;

        //property to access value of the lazy instance
        public TabInfoViewModel TabInfoVM => _tabInfoViewModel.Value;

        private readonly IRestoDataService _restoDataService;

        public TabReviewViewModel(IRestoDataService restoDataService)
        {
            this._restoDataService = restoDataService;

            //initzialize lazy instance via ioc construct
            _tabInfoViewModel = new Lazy<TabInfoViewModel>(Mvx.IocConstruct<TabInfoViewModel>);
        }
    }
}