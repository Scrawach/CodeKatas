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
}