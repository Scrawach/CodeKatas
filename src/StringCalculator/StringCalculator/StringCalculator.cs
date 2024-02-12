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

    private static int ExecuteAdd(IEnumerable<string> args)
    {
        var numbers = args.Select(int.Parse).ToArray();
        var negativeNumbers = numbers.Where(n => n < 0).ToArray();

        if (negativeNumbers.Any())
            throw new NegativeNotAllowed(string.Join(",", negativeNumbers));
        
        return ExecuteAdd(numbers);
    }

    private static int ExecuteAdd(int[] numbers) =>
        numbers.Where(n => n < 1000).Sum();

    private static IEnumerable<string> CustomSplit(string args)
    {
        var values = args.Split('\n');
        var numbers = values[1];
        var customDelimiter = ParseDelimiter(args);
        return numbers.Split(customDelimiter, StringSplitOptions.RemoveEmptyEntries);
    }

    private static string[] ParseDelimiter(string args)
    {
        var values = args.Split('\n');
        var delimiter = values[0];
        var isAnyLengthDelimiter = args[2] == '[';

        if (isAnyLengthDelimiter)
        {
            var delimiter1 = delimiter.TrimStart('/').Remove(0, 1);
            var delimiter2 = delimiter1.Remove(delimiter1.Length - 1, 1);
            var delimiters = delimiter2.Split("][");
            return delimiters;
        }

        return new[] { args[2].ToString() };
    }

    private static IEnumerable<string> DefaultSplit(string args) =>
        args.Split(',', '\n');
}