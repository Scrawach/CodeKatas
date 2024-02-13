namespace AsteriskTower;

public class AsteriskTower
{
    private readonly int _rows;

    public AsteriskTower(int rows) =>
        _rows = rows;

    public string[] Build() =>
        _rows == 1 
            ? new[] { "*" } 
            : Array.Empty<string>();
}