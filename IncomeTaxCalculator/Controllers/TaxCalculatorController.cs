using IncomeTaxCalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace IncomeTaxCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxCalculatorController : ControllerBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;

        public TaxCalculatorController(ITaxCalculatorService taxCalculatorService)
        {
            _taxCalculatorService = taxCalculatorService;
        }

        [HttpGet("{countryCode}/{annualIncome}")]
        public IActionResult CalculateIncomeTax(string countryCode, decimal annualIncome)
        {
            return Ok(_taxCalculatorService.Calculate(countryCode, annualIncome));
        }
    }
}