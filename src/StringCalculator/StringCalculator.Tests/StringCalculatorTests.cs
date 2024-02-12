using FluentAssertions;

namespace StringCalculator.Tests;

public class StringCalculatorTests
{
    [Test]
    public void WhenAddEmptyString_ThenShouldReturnZero()
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(string.Empty);

        // answer
        result.Should().Be(0);
    }

    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("3", 3)]
    public void WhenAddSingleNumber_ThenShouldReturnThisNumber(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }

    [TestCase("1,2", 3)]
    [TestCase("3,4", 7)]
    [TestCase("10,15", 25)]
    public void WhenAddTwoNumbers_ThenShouldReturnTheirNumber(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }
}