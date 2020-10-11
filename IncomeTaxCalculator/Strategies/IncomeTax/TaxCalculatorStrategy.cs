using System.Collections.Generic;
using System.Linq;
using IncomeTaxCalculator.Models;

namespace IncomeTaxCalculator.Strategies.IncomeTax
{
    public abstract class TaxCalculatorStrategy : ITaxCalculatorStrategy
    {
        protected abstract IEnumerable<TaxLevel> TaxLevels { get;  }
        public decimal CalculateTaxFor(decimal annualIncome)
        {
            var totalTax = 0m;
            var remaining = annualIncome;

            var levels = TaxLevels.Where(x => x.Start < annualIncome).OrderByDescending(x => x.Rate);
            foreach (var taxLevel in levels)
            {
                var taxableAmount = remaining - taxLevel.Start;
                var taxCalculated = taxableAmount * taxLevel.Rate * 0.01m;

                totalTax += taxCalculated;
                remaining -= taxableAmount;
            }
            
            return totalTax;
        }
    }
}