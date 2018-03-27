using MvvmCross.Core.ViewModels;
using NMCT.TipCalculator.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.TipCalculator.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private ICalculationService calculationService;

        public TipViewModel(ICalculationService _calculationService)
        {
            _calculationService = calculationService;
        }

        private double _payed;

        public double Payed
        {
            get
            {
                return _payed;
            }
            set
            {
                _payed = value;
                RaisePropertyChanged(() => Payed);
                Tip = _calculationService.Calculate(Payed, Procent);
            }
        }

        private double _procent;

        public double Procent
        {
            get
            {
                return _procent;
            }
            set
            {
                _procent = value;
                RaisePropertyChanged(() => Procent);
                Tip = _calculationService.Calculate(Payed, Procent);
            }
        }

        private double _tip;

        public double Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
                Tip = _calculationService.Calculate(Payed, Procent);
            }
        }
    }
}
