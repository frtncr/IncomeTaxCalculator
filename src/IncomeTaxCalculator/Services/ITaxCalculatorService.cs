namespace IncomeTaxCalculator.Services
{
    public interface ITaxCalculatorService
    {
        public decimal Calculate(string countryCode, decimal annualIncome);
    }
}