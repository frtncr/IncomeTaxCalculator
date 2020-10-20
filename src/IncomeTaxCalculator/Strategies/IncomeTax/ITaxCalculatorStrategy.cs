namespace IncomeTaxCalculator.Strategies.IncomeTax
{
    public interface ITaxCalculatorStrategy
    {
        public decimal CalculateTaxFor(decimal annualIncome);
    }
}