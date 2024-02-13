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
        var spacesWidth = amount - 1;
        var towerWidth = 1;
        
        for (var i = 0; i < amount; i++)
        {
            yield return Row(spacesWidth, towerWidth);
            spacesWidth--;
            towerWidth += 2;
        }
    }

    private static string Row(int spacesWidth, int towerWidth) =>
        $"{Spaces(spacesWidth)}{Tower(towerWidth)}{Spaces(spacesWidth)}";

    private static string Spaces(int width) =>
        new(' ', width);
    
    private static string Tower(int width) =>
        new('*', width);
}