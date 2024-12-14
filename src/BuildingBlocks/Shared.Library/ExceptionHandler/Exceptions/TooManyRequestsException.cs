namespace Shared.Library.Exceptions.Exceptions;

public class TooManyRequestsException : Exception
{
    public TooManyRequestsException(string message = "Rate limit exceeded") : base(message)
    {
    }
}
