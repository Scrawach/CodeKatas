namespace AsteriskTower;

public class AsteriskTower
{
    private readonly int _rows;

    public AsteriskTower(int rows) =>
        _rows = rows;

    public string[] Build() =>
        _rows > 0 
            ? Build(_rows) 
            : Array.Empty<string>();

    private static string[] Build(int rows) =>
        Rows(rows).ToArray();

    private static IEnumerable<string> Rows(int amount)
    {
        for (var i = 0; i < amount; i++)
        {
            var spacesWidth = amount - i - 1;
            var towerWidth = i * 2 + 1;
            yield return Row(spacesWidth, towerWidth);
        }
    }

    private static string Row(int spacesWidth, int towerWidth) =>
        $"{Spaces(spacesWidth)}{Tower(towerWidth)}{Spaces(spacesWidth)}";

    private static string Spaces(int width) =>
        new(' ', width);
    
    private static string Tower(int width) =>
        new('*', width);
}