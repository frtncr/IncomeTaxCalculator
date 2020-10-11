using System.Collections.Generic;
using IncomeTaxCalculator.Models;

namespace IncomeTaxCalculator.Strategies.IncomeTax
{
    public class TurkeyTaxCalculatorStrategy : TaxCalculatorStrategy
    {
        protected override IEnumerable<TaxLevel> TaxLevels =>
            new List<TaxLevel>
            {
                new TaxLevel {Start = 0m, End = 22000m, Rate = 15},
                new TaxLevel {Start = 22000m, End = 49000m, Rate = 20},
                new TaxLevel {Start = 49000m, End = 180000m, Rate = 27},
                new TaxLevel {Start = 180000m, End = 600000m, Rate = 35},
                new TaxLevel {Start = 600000m, End = decimal.MaxValue, Rate = 40}
            };
    }
}