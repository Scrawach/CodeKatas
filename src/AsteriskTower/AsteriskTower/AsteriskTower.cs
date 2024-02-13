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
        var amountOfSpaces = amount - 1;
        var amountOfSymbols = 1;
        
        for (var i = 0; i < amount; i++)
        {
            yield return Row(amountOfSpaces, amountOfSymbols);
            amountOfSpaces--;
            amountOfSymbols += 2;
        }
    }

    private static string Row(int amountOfSpaces, int amountOfSymbols) =>
        $"{new string(' ', amountOfSpaces)}{new string('*', amountOfSymbols)}{new string(' ', amountOfSpaces)}";
}