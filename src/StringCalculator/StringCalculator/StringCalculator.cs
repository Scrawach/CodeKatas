namespace StringCalculator;

public class StringCalculator
{
    public int Add(string args) =>
        string.IsNullOrWhiteSpace(args) 
            ? 0 
            : Add(args.Split(',', '\n'));

    private static int Add(IEnumerable<string> args) =>
        args.Select(int.Parse).Sum();
}