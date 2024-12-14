namespace Shared.Library.Response; 

public interface IDataResponse<out T>
{
    public T Data { get; }
}
