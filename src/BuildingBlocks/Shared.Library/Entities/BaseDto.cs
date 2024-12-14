namespace Shared.Library.Entities;

public abstract class BaseDto
{    
    public virtual bool IsSuccess { get; set; } = true;
    public virtual string Message { get; set; } = string.Empty;
}
