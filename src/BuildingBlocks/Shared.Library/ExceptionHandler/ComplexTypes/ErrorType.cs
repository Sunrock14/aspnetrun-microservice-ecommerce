namespace Shared.Library.Exceptions.ComplexTypes;

public enum ErrorType
{
    ValidationError,
    NotFound,
    Unauthorized,
    Forbidden,
    BadRequest,
    Conflict,
    ServiceUnavailable,
    Timeout,
    TooManyRequests,
    PayloadTooLarge,
    DatabaseError,
    ExternalServiceError,
    InternalServerError
}
