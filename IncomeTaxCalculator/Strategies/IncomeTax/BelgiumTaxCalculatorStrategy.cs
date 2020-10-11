using System.Collections.Generic;
using IncomeTaxCalculator.Models;

namespace IncomeTaxCalculator.Strategies.IncomeTax
{
    public class BelgiumTaxCalculatorStrategy : TaxCalculatorStrategy
    {
        protected override IEnumerable<TaxLevel> TaxLevels =>
            new List<TaxLevel>
            {
                new TaxLevel {Threshold = 0m, Rate = 25},
                new TaxLevel {Threshold = 13500m, Rate = 40},
                new TaxLevel {Threshold = 23390m, Rate = 45},
                new TaxLevel {Threshold = 40480m, Rate = 50}
            };
    }
}