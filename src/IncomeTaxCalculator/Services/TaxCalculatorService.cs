using System;
using IncomeTaxCalculator.Contexts;
using IncomeTaxCalculator.Strategies.IncomeTax;

namespace IncomeTaxCalculator.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        private TaxCalculatorContext _context;

        public decimal Calculate(string countryCode, decimal annualIncome)
        {
            _context = new TaxCalculatorContext(ResolveTaxCalculatorStrategy(countryCode));

            return _context.Calculate(annualIncome);
        }

        private static ITaxCalculatorStrategy ResolveTaxCalculatorStrategy(string countryCode)
        {
            return countryCode switch
            {
                "TR" => new TurkeyTaxCalculatorStrategy(),
                "BE" => new BelgiumTaxCalculatorStrategy(),
                _ => throw new Exception($"Tax calculator not implemented for {countryCode}")
            };
        }
    }
}