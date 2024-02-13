namespace AsteriskTower;

public class AsteriskTower
{
    private readonly int _rows;

    public AsteriskTower(int rows) =>
        _rows = rows;

    public string[] Build()
    {
        if (_rows == 1)
            return new[] { "*" };
        
        return Array.Empty<string>();
    }
}