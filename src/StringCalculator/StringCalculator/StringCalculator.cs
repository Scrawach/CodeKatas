namespace StringCalculator;

public class StringCalculator
{
    public int Add(string args)
    {
        if (args == string.Empty)
            return 0;
        return int.Parse(args);
    }
}