using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething() 
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual); 

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.018008,-86.079099,Taco Bell Attall...", -86.079099)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", -85.499655)]
        [InlineData("32.609135,-85.479907,Taco Bell Auburn...", -85.479907)]
        [InlineData("33.49763,-86.875722, Taco Bell Birmingham...", -86.875722)]
        [InlineData("33.635282,-86.684056, Taco Bell Birmingham...", -86.684056)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var longTest = new TacoParser();
            //Act
            var actual = longTest.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.018008,-86.079099,Taco Bell Attall...", 34.018008)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", 32.571331)]
        [InlineData("32.609135,-85.479907,Taco Bell Auburn...", 32.609135)]
        [InlineData("33.49763,-86.875722, Taco Bell Birmingham...", 33.49763)]
        [InlineData("33.635282,-86.684056, Taco Bell Birmingham...", 33.635282)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var latTest = new TacoParser();
            //Act
            var actual = latTest.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
