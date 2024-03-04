using FluentAssertions;

namespace AsteriskTower.Tests;

public class AsteriskTowerTests
{
    [Test]
    public void WhenAsteriskTower_HasZeroRows_ThenShouldReturnEmptyArray()
    {
        // arrange
        var asteriskTower = new AsteriskTower(0);

        // act
        var stringTower = asteriskTower.Build();

        // answer
        stringTower.Should().BeEmpty();
    }

    [Test]
    public void WhenAsteriskTower_HasOneRow_ThenShouldReturnOneSymbol()
    {
        // arrange
        var asteriskTower = new AsteriskTower(1);

        // act
        var stringTower = asteriskTower.Build();

        // answer
        stringTower.Should().Equal("*");
    }

    [TestCase(2, new[] { " * ", "***"})]
    [TestCase(3, new[] { "  *  ", " *** ", "*****"})]
    [TestCase(4, new[] { "   *   ", "  ***  ", " ***** ", "*******"})]
    [TestCase(5, new[] { "    *    ", "   ***   ", "  *****  ", " ******* ", "*********"})]
    public void WhenAsteriskTower_HasFewRows_ThenShouldReturnSymbolsTower(int rows, string[] expected)
    {
        // arrange
        var asteriskTower = new AsteriskTower(rows);

        // act
        var stringTower = asteriskTower.Build();

        // answer
        stringTower.Should().Equal(expected);
    }
}