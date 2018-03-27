using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineApp.Core.Models;

namespace WineApp.Core.ViewModels
{
    public class WinesViewModel : MvxViewModel
    {
        private List<Wine> _wines;

        public List<Wine> Wines
        {
            get { return _wines; }
            set
            {
                _wines = value;
                RaisePropertyChanged(() => Wines);
            }
        }

        public WinesViewModel()
        {

        }
    }

}
