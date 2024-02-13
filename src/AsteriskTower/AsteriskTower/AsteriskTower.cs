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

    private static string[] Build(int rows)
    {
        var amountOfSpaces = rows - 1;
        var amountOfSymbols = 1;
        var lines = new List<string>();

        for (var i = 0; i < rows; i++)
        {
            var line = $"{new string(' ', amountOfSpaces)}{new string('*', amountOfSymbols)}{new string(' ', amountOfSpaces)}";
            amountOfSpaces--;
            amountOfSymbols += 2;
            lines.Add(line);
        }
        
        return lines.ToArray();
    }
}