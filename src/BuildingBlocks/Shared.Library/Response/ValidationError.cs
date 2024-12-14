namespace Shared.Library.Response;

public class ValidationError
{
    public string PropertyName { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
