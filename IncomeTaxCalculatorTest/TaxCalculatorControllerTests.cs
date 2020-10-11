using IncomeTaxCalculator.Controllers;
using IncomeTaxCalculator.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace IncomeTaxCalculatorTest
{
    public class TaxCalculatorControllerTests
    {
        // private TaxCalculatorController _sut;
        //
        // public TaxCalculatorControllerTests()
        // {
        //     _sut = new TaxCalculatorController();
        // }

        [Fact]
        public void CalculateIncomeTaxAction_ShouldNotReturn_Null()
        {
            // Arrange
            var mockTaxCalculatorService = new Mock<ITaxCalculatorService>();
            mockTaxCalculatorService.Setup(x => x.Calculate("TR", 32000m))
                .Returns(5300m);
            
            var sut = new TaxCalculatorController(mockTaxCalculatorService.Object);

            // Act
            var result = sut.CalculateIncomeTax("TR", 32000m) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}