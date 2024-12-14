namespace Shared.Library.Exceptions.Exceptions;

public class DatabaseException : Exception
{
    public DatabaseException(string message, Exception innerException = null)
        : base(message, innerException)
    {
    }
}
