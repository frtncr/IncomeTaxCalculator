using System.Collections.Generic;
using IncomeTaxCalculator.Models;

namespace IncomeTaxCalculator.Strategies.IncomeTax
{
    public class TurkeyTaxCalculatorStrategy : TaxCalculatorStrategy
    {
        protected override IEnumerable<TaxLevel> TaxLevels =>
            new List<TaxLevel>
            {
                new TaxLevel {Threshold = 0m, Rate = 15},
                new TaxLevel {Threshold = 22000m, Rate = 20},
                new TaxLevel {Threshold = 49000m, Rate = 27},
                new TaxLevel {Threshold = 180000m, Rate = 35},
                new TaxLevel {Threshold = 600000m, Rate = 40}
            };
    }
}