using IncomeTaxCalculator.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace IncomeTaxCalculatorTest
{
    public class HomeControllerTests
    {
        private readonly HomeController _sut;

        public HomeControllerTests()
        {
            _sut = new HomeController();
        }

        [Fact]
        public void Index_ShouldNotReturn_Null()
        {
            // Arrange
            
            // Act
            var result = _sut.Index() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Index_ShouldReturn_Message()
        {
            // Arrange
            
            // Act
            var result = _sut.Index() as OkObjectResult;

            // Assert
            Assert.Equal("Welcome to the Income Calculator API", result?.Value);
        }
        
        [Fact]
        public void Index_ShouldReturnHttpOk()
        {
            // Arrange
            
            // Act
            var result = _sut.Index() as OkObjectResult;

            // Assert
            Assert.Equal(200, result?.StatusCode);
        }
    }
}