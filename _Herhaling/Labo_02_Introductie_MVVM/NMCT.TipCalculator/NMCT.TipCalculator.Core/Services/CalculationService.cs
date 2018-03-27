using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.TipCalculator.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal Calculate(decimal payed, decimal procent)
        {
            return (payed * procent) / 100;
        }
    }
}
