using System.Collections.Generic;
using IncomeTaxCalculator.Models;

namespace IncomeTaxCalculator.Strategies.IncomeTax
{
    public class BelgiumTaxCalculatorStrategy : TaxCalculatorStrategy
    {
        protected override IEnumerable<TaxLevel> TaxLevels =>
            new List<TaxLevel>
            {
                new TaxLevel {Start = 0m, End = 13500m, Rate = 25},
                new TaxLevel {Start = 13500m, End = 23390m, Rate = 40},
                new TaxLevel {Start = 23390m, End = 40480m, Rate = 45},
                new TaxLevel {Start = 40480m, End = decimal.MaxValue, Rate = 50}
            };
    }
}