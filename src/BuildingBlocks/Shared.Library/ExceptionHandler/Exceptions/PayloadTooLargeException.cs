namespace Shared.Library.Exceptions.Exceptions;

public class PayloadTooLargeException : Exception
{
    public PayloadTooLargeException(string message = "Payload size exceeds limit") : base(message)
    {
    }
}
