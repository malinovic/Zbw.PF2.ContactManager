
namespace Zbw.PF2.ContactManager.Validation;


public sealed record ValidationError

{    public string PropertyName { get; }

    public string Message { get; }


    public ValidationError(string propertyName, string message)
    {

        ArgumentException.ThrowIfNullOrWhiteSpace(propertyName);
        ArgumentException.ThrowIfNullOrWhiteSpace(message);
        PropertyName = propertyName;
        Message = message;
    }
}