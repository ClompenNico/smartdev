using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakenApp.Shared.ViewModels
{
    public class MainTabViewModel : MvxViewModel
    {
        private readonly Lazy<TaskViewModel> _tabTasks;
        public TaskViewModel TaskViewModelVM => _tabTasks.Value;

        private readonly Lazy<UserOverViewModel> _tabUsers;
        public UserOverViewModel UserOverViewModelVM => _tabUsers.Value;

        public MainTabViewModel()
        {
            _tabTasks = new Lazy<TaskViewModel>(Mvx.IocConstruct<TaskViewModel>);
            _tabUsers = new Lazy<UserOverViewModel>(Mvx.IocConstruct<UserOverViewModel>);
        }
    }
}
