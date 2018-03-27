namespace NMCT.TipCalculator.Core.Services
{
    public interface ICalculationService
    {
        decimal Calculate(decimal payed, decimal procent);
    }
}