using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using NMCT.Resto.Core.ViewModels;
using System;
using UIKit;

namespace NMCT.Resto.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class RestoTabsView : MvxTabBarViewController<RestoTabsViewModel>
    {
        private bool _constructed;

        public RestoTabsView()
        {
            _constructed = true;
            ViewDidLoad();
        }


        public override void ViewDidLoad()
        {
            if (!_constructed) return;

            base.ViewDidLoad();

            //tabs aanmaken
            CreateTabs();
        }

        private void CreateTabs()
        {
            //voeg viewcontrollers toe voor elk tabblad en bewaar
            var viewControllers = new UIViewController[]
            {
                CreateSingleTab("Info", ViewModel.TabInfoVM),
            };

            //Alls ViewControllers niet herkend is check dan uw overerving bovenaan (:MvxTabBarViewModel)
            ViewControllers = viewControllers;

            //stel de eerste tab in als geselecteerd
            SelectedViewController = ViewControllers[0];

            //pas titel aan bij het selecteren van een tabblad
            NavigationItem.Title = SelectedViewController.Title;

            ViewControllerSelected += (o, e) =>
            {
                NavigationItem.Title = TabBar.SelectedItem.Title;
            };

        }

        private UIViewController CreateSingleTab(string tabName, MvxViewModel tabViewModel)
        {
            //viewcontroller aanmaken adhv viewmodel
            var viewController =
                this.CreateViewControllerFor(tabViewModel) as UIViewController;
            tabViewModel.Start();

            //titel instellen op naam tabblad
            viewController.Title = tabName;
            viewController.TabBarItem = new UITabBarItem() { Title = tabName };

            return viewController;

        }

        /*public RestoTabsView (IntPtr handle) : base (handle)
        {
            public RestoTabsView()
            {

            }
        }*/
    }
}