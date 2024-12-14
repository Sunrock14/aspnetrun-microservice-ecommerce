using Shared.Library.Exceptions.ComplexTypes;

namespace Shared.Library.ExceptionHandler.Models;

public class CustomErrorResponse
{
    public string TraceId { get; set; } = default!;
    public DateTime Timestamp { get; set; }
    public int StatusCode { get; set; }
    public string Message { get; set; } = default!;
    public string Path { get; set; } = default!;
    public ErrorType ErrorType { get; set; }
    public IEnumerable<string> Errors { get; set; } = default!;
    public DeveloperMessage DeveloperMessage { get; set; } = default!;
}
