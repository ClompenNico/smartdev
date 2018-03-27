using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;
using UIKit;
using WineApp.Core.ViewModels;
using WineApp.iOS.TableViewSources;

namespace WineApp.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class WineView : MvxTableViewController<WinesViewModel>
    {
        private WineViewSource _wineViewSource;

        public override void ViewDidLoad()
        {
            _wineViewSource = new WineViewSource(this.TableView);
            base.ViewDidLoad();

            this.TableView.Source = _wineViewSource;
            this.TableView.ReloadData();

            MvxFluentBindingDescriptionSet<WineView, WinesViewModel> set = new MvxFluentBindingDescriptionSet<WineView, WinesViewModel>(this);
            set.Bind(_wineViewSource).To(vm => vm.Wines);

            set.Apply();
        }
    }
}