namespace StringCalculator;

public class StringCalculator
{
    public int Add(string args) =>
        string.IsNullOrWhiteSpace(args) 
            ? 0 
            : ExecuteAdd(args);

    private static int ExecuteAdd(string args)
    {
        if (args.StartsWith("//"))
        {
            var customDelimiter = args[2];
            var numbers = args.Split('\n')[1];
            return Add(numbers.Split(customDelimiter));
        }
        return Add(args.Split(',', '\n'));
    }
    
    private static int Add(IEnumerable<string> args) =>
        args.Select(int.Parse).Sum();
}