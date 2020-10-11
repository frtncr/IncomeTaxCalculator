using IncomeTaxCalculator.Strategies.IncomeTax;

namespace IncomeTaxCalculator.Contexts
{
    public class TaxCalculatorContext
    {
        private readonly ITaxCalculatorStrategy _taxCalculatorStrategy;

        public TaxCalculatorContext(ITaxCalculatorStrategy taxCalculatorStrategy)
        {
            _taxCalculatorStrategy = taxCalculatorStrategy;
        }

        public decimal Calculate(decimal annualIncome)
        {
            return _taxCalculatorStrategy.CalculateTaxFor(annualIncome);
        }
    }
}