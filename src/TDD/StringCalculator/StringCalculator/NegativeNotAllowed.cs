namespace StringCalculator;

public class NegativeNotAllowed : Exception
{
    public NegativeNotAllowed(string message) : base(message) { }
}