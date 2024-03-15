namespace EastSeat.Patabei.Application.Responses;

public class BaseResponse<T> where T : class
{
    /// <summary>
    /// True if response is a success, otherwise false.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Response message.
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Response error code.
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// Initializes <see cref="BaseResponse"/>.
    /// </summary>
    public BaseResponse()
    {
        Success = true;
    }

    /// <summary>
    /// Initializes <see cref="BaseResponse"/>.
    /// </summary>
    /// <param name="message">Message associated with the response.</param>
    public BaseResponse(string message)
    {
        Success = true;
        Message = message;
    }

    /// <summary>
    /// Initializes <see cref="BaseResponse"/>.
    /// </summary>
    /// <param name="success">True if response is a success, otherwise False.</param>
    /// <param name="message">Message associated with the response.</param>
    public BaseResponse(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    /// <summary>
    /// Instantiates <see cref="BaseResponse"/>
    /// </summary>
    /// <param name="success"></param>
    /// <param name="message"></param>
    /// <param name="errorCode"></param>
    public BaseResponse(bool success, string message, string errorCode)
    {
        Success = success;
        Message = message;
        ErrorCode = errorCode;
    }

    /// <summary>
    /// Response content.
    /// </summary>
    public T? Content { get; set; } = default;
}