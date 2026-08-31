namespace Zbw.PF2.ContactManager.Core.Validation;

/// <summary>
///     Collects the <see cref="ValidationError" />s produced while validating an input object.
/// </summary>
public sealed class ValidationResult
{
    private readonly List<ValidationError> _errors = [];

    public IReadOnlyCollection<ValidationError> Errors => _errors;

    public bool IsValid => _errors.Count == 0;


    /// <summary>
    ///     Records a validation failure for the given property.
    /// </summary>
    /// <param name="propertyName">The name of the property that failed validation.</param>
    /// <param name="message">The validation failure message.</param>
    public void Add(string propertyName, string message)
    {
        ValidationError error = new(propertyName, message);
        _errors.Add(error);
    }

    /// <summary>
    ///     Retrieves all error messages recorded for the given property.
    /// </summary>
    /// <param name="propertyName">The name of the property to look up errors for.</param>
    /// <returns>The error messages for the property, or an empty sequence if none were recorded.</returns>
    public IEnumerable<string> GetErrors(string propertyName)
    {
        return _errors
            .Where(error => error.PropertyName == propertyName)
            .Select(error => error.Message);
    }


}
