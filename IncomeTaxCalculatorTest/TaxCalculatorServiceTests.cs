using System;
using IncomeTaxCalculator.Services;
using IncomeTaxCalculator.Strategies.IncomeTax;
using Xunit;

namespace IncomeTaxCalculatorTest
{
    public class TaxCalculatorServiceTests
    {
        [Fact]
        public void ZeroAnnualIncome_ShouldReturn_Zero()
        {
            // Arrange
            var sut = new TaxCalculatorService();
            
            // Act
            var result = sut.Calculate("BE", Decimal.Zero);

            //Assert
            Assert.Equal(Decimal.Zero, result);
        }
        
        [Fact]
        public void GivenAnnualIncome_ShouldNotReturn_Null()
        {
            // Arrange
            var sut = new TaxCalculatorService();
            
            // Act
            var result = sut.Calculate("TR", 32000m);

            // Assert
            Assert.NotEqual(Decimal.Zero, result);
        }

        [Fact]
        public void NonExistingCountryCode_ShouldThrow_Exception()
        {
            // Arrange
            var sut = new TaxCalculatorService();
            
            // Act
            
            // Assert
            Assert.Throws<Exception>(() => sut.Calculate("AA", 25000m));
        }
    }
}