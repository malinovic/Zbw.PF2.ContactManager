namespace Zbw.PF2.ContactManager.Core.Validation;


/// <summary>
///     Represents a single validation failure for a named property.
/// </summary>
public sealed record ValidationError

{
    public string PropertyName { get; }

    public string Message { get; }


    /// <summary>
    ///     Initializes a new instance of <see cref="ValidationError" />.
    /// </summary>
    /// <param name="propertyName">The name of the property that failed validation.</param>
    /// <param name="message">The validation failure message.</param>
    public ValidationError(string propertyName, string message)
    {

        ArgumentException.ThrowIfNullOrWhiteSpace(propertyName);
        ArgumentException.ThrowIfNullOrWhiteSpace(message);
        PropertyName = propertyName;
        Message = message;
    }
}