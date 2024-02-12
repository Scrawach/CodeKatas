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
    public void WhenAddTwoNumbers_SeparatedByCommas_ThenShouldReturnTheirSum(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }

    [TestCase("1,2,3", 6)]
    [TestCase("1,2,3,4", 10)]
    [TestCase("1,2,3,4,5", 15)]
    [TestCase("1,2,3,4,5,6", 21)]
    public void WhenAddManyNumbers_SeparatedByCommas_ThenShouldReturnTheirSum(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }

    [TestCase("1\n2,3", 6)]
    [TestCase("1\n2,3\n4,5", 15)]
    public void WhenAddManyNumbers_SeparatedByCommasOrNewline_ThenShouldReturnTheirSum(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }

    [TestCase("//;\n1;2", 3)]
    [TestCase("//;\n1;2;3", 6)]
    [TestCase("//;\n1;2;3;4", 10)]
    public void WhenAddManyNumbers_SeparatedByCustomDelimiters_ThenShouldReturnTheirSum(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }

    [TestCase("1,-2,3","-2")]
    public void WhenAddNegativeNumbers_ThenShouldThrowException_WithThisNumbers(string input, string expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        Action act = () => calculator.Add(input);

        // answer
        act.Should().Throw<NegativeNotAllowed>(expected);
    }

    [TestCase("2,1001", 2)]
    public void WhenAddNumbers_ThatBiggerThan1000_ThenShouldIgnoreTheir(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }

    [TestCase("//[***]\n1***2***3***", 6)]
    [TestCase("//[---]\n1---2---3---", 6)]
    public void WhenAddManyNumbers_WithCustomDelimiterAnyLength_ThenShouldReturnTheirSum(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }

    [TestCase("//[*][%]\n1*2%3", 6)]
    public void WhenAddManyNumbers_WithMultipleCustomDelimiters_ThenShouldReturnTheirSum(string input, int expected)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // answer
        result.Should().Be(expected);
    }
}