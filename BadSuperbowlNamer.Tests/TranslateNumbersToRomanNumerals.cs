using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class TranslateNumbersToRomanNumerals // name the test for what youre testing 
    {
        [Fact] // this says this is a test
        public void when_the_number_1_is_passed_i_should_be_returned() // must be public, return void and take no params
        {
            //Arrange -> context creation
            var numberToConvert = 1;
            var translator = new RomanNumeralTranslator();

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            // equal(expected, actual) order is important
            Assert.Equal("I", result);
        }

        [Fact]
        public void when_the_number_5_is_passed_V_should_be_returned()
        {
            //Arrange
            var numberToConvert = 5;
            var translator = new RomanNumeralTranslator();

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal("V", result);
        }

        [Fact]
        public void when_the_number_9_is_passed_IX_should_be_returned()
        {
            //Arrange
            var numberToConvert = 9;
            var translator = new RomanNumeralTranslator();

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal("IX", result);
        }
    }
}
