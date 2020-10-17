using IncomeTaxCalculator.Controllers;
using IncomeTaxCalculator.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace IncomeTaxCalculatorTest
{
    public class TaxCalculatorControllerTests
    {
        private readonly TaxCalculatorController _sut;
        private readonly Mock<ITaxCalculatorService> _mockTaxCalculatorService;
        
        public TaxCalculatorControllerTests()
        {
            _mockTaxCalculatorService = new Mock<ITaxCalculatorService>();
            _sut = new TaxCalculatorController(_mockTaxCalculatorService.Object);
        }

        [Fact]
        public void CalculateIncomeTax_ShouldNotReturnNull_WhenCountryCodeIsValid()
        {
            // Arrange
            _mockTaxCalculatorService.Setup(x => x.Calculate("TR", 32000m))
                .Returns(5300m);
            
            // Act
            var result = _sut.CalculateIncomeTax("TR", 32000m) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}