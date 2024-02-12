namespace StringCalculator;

public class StringCalculator
{
    public int Add(string args) =>
        string.IsNullOrWhiteSpace(args) 
            ? 0 
            : ExecuteAdd(args);

    private static int ExecuteAdd(string args) =>
        HasCustomDelimiter(args)
            ? ExecuteAdd(CustomSplit(args))
            : ExecuteAdd(DefaultSplit(args));

    private static bool HasCustomDelimiter(string args) =>
        args.StartsWith("//");

    private static int ExecuteAdd(IEnumerable<string> args) =>
        args.Select(int.Parse).Sum();

    private static IEnumerable<string> CustomSplit(string args)
    {
        var customDelimiter = args[2];
        var numbers = args.Split('\n')[1];
        return numbers.Split(customDelimiter);
    }

    private static IEnumerable<string> DefaultSplit(string args) =>
        args.Split(',', '\n');
}