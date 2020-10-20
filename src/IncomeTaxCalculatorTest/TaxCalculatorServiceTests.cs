using System;
using IncomeTaxCalculator.Services;
using IncomeTaxCalculator.Strategies.IncomeTax;
using Xunit;

namespace IncomeTaxCalculatorTest
{
    public class TaxCalculatorServiceTests
    {
        [Fact]
        public void Calculate_ShouldThrowException_WhenCountryCodeIsInvalid()
        {
            // Arrange
            var sut = new TaxCalculatorService();
            
            // Act
            
            // Assert
            Assert.Throws<Exception>(() => sut.Calculate("AA", 25000m));
        }
        
        [Fact]
        public void Calculate_ShouldReturnZero_WhenAnnualIncomeZero()
        {
            // Arrange
            var sut = new TaxCalculatorService();
            
            // Act
            var result = sut.Calculate("BE", decimal.Zero);

            //Assert
            Assert.Equal(decimal.Zero, result);
        }
        
        [Fact]
        public void Calculate_ShouldNotReturnNull_WhenAnnualIncomeGreaterThanZero()
        {
            // Arrange
            var sut = new TaxCalculatorService();
            
            // Act
            var result = sut.Calculate("TR", 32000m);

            // Assert
            Assert.NotEqual(Decimal.Zero, result);
        }
        
        [Fact]
        public void Calculate_ShouldReturnGreaterThanZero_WhenAnnualIncomeGreaterThanZero()
        {
            // Arrange
            var sut = new TaxCalculatorService();
            
            // Act
            var result = sut.Calculate("TR", 32000m);

            // Assert
            Assert.True(result > decimal.Zero);
        }
    }
}