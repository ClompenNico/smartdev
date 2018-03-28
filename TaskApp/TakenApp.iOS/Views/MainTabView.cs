using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using System;
using TakenApp.Shared.ViewModels;
using UIKit;

namespace TakenApp.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class MainTabView : MvxTabBarViewController<MainTabViewModel>
    {
        private bool _constructed;
        public MainTabView(IntPtr handle) : base(handle)
        {
            _constructed = true;
            ViewDidLoad();
        }
        public override void ViewDidLoad()
        {
            if (!_constructed) return;

            base.ViewDidLoad();
            NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Add);
            NavigationItem.LeftBarButtonItem.Clicked += (s, o) =>
            {
                MvxTableViewController ctrl = SelectedViewController as MvxTableViewController;
                if (ctrl.ViewModel.GetType().Equals(typeof(TaskViewModel)))
                {
                    TaskViewModel vm = ctrl.ViewModel as TaskViewModel;
                    //hier kan je CreateTaskCommand aanroepen op het viewmodel
                    //vb: vm.CreateTaskCommand.Execute();
                }

                if (ctrl.ViewModel.GetType().Equals(typeof(UserOverViewModel)))
                {
                    UserOverViewModel vm = ctrl.ViewModel as UserOverViewModel;
                    //hier kan je CreateUserCommand aanroepen op het viewmodel
                    //vm.CreateUserCommand.Execute();
                }
            };
            NavigationItem.RightBarButtonItem = EditButtonItem;
            //tabs aanmaken
            CreateTabs();
        }

        private void CreateTabs()
        {
            //voeg viewcontrollers toe voor elk tabblad en bewaar
            var viewControllers = new UIViewController[]
            {
                CreateSingleTab("Taken", ViewModel.TaskViewModelVM),
                CreateSingleTab("Gebruikers", ViewModel.UserOverViewModelVM),
            };

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
            var viewController = this.CreateViewControllerFor(tabViewModel) as UIViewController;
            tabViewModel.Start();

            //titel instellen op naam tabblad
            viewController.Title = tabName;
            viewController.TabBarItem = new UITabBarItem() { Title = tabName };

            return viewController;
        }
    }
}