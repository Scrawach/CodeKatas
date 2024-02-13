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
}