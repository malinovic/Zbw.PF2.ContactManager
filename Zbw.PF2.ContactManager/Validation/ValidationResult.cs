using System;
using System.Collections.Generic;
using System.Text;

namespace Zbw.PF2.ContactManager.Validation;

public sealed class ValidationResult
{
    private readonly List<ValidationError> _errors = [];

    public IReadOnlyCollection<ValidationError> Errors => _errors;

    public bool IsValid => _errors.Count == 0;


    public void Add(string propertyName, string message)
    {
        ValidationError error = new(propertyName, message);
        _errors.Add(error);
    }

    public IEnumerable<string> GetErrors(string propertyName)
    {
        return _errors
            .Where(error => error.PropertyName == propertyName)
            .Select(error => error.Message);
    }


}
