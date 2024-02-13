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
        stringTower.Should().BeSameAs(new[] { "*"});
    }
}