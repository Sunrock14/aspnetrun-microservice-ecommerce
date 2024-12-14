namespace Shared.Library.ExceptionHandler.Models;

public class DeveloperMessage
{
    public string Exception { get; set; } = default!;
    public string ExceptionMessage { get; set; } = default!;
    public string StackTrace { get; set; } = default!;
    public string Source { get; set; } = default!;
    public string InnerException { get; set; } = default!;
}
