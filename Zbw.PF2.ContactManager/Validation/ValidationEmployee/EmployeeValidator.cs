using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Zbw.PF2.ContactManager.Validation.ValidationEmployee;

public sealed class EmployeeValidator
{

    private static void ValidateBirthday(
    EmployeeInput input,
    ValidationResult result)
    {
        if (string.IsNullOrWhiteSpace(input.Birthday))
        {
            result.Add(nameof(input.Birthday),
                "Das Geburtsdatum ist erforderlich.");

            return;
        }

        bool isValidDate = DateTime.TryParseExact(input.Birthday.Trim(),
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime birthday);

        if (!isValidDate)
        {
            result.Add(nameof(input.Birthday),
                "Das Geburtsdatum muss im Format TT.MM.JJJJ eingegeben werden.");

            return;
        }

        if (birthday.Date > DateTime.Today)
        {
            result.Add(nameof(input.Birthday),
                "Das Geburtsdatum darf nicht in der Zukunft liegen.");

            return;
        }

        int age = DateTime.Today.Year - birthday.Year;

        if (birthday.Date > DateTime.Today.AddYears(-age))
        {
            age--;
        }

        if (age > 120)
        {
            result.Add(nameof(input.Birthday),
                "Das Geburtsdatum ist nicht plausibel.");
        }
    }
    public ValidationResult Validate(EmployeeInput input)
    {
        ArgumentNullException.ThrowIfNull(input);

        ValidationResult result = new();

        if (input.Salutation is null)
        {
            result.Add(
                nameof(input.Salutation),
                "Bitte wählen Sie eine Anrede aus.");
        }

        if (string.IsNullOrWhiteSpace(input.FirstName))
        {
            result.Add(nameof(input.FirstName),
                "Der Vorname ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.LastName))
        {
            result.Add(nameof(input.LastName),
                "Der Nachname ist erforderlich.");
        }

        ValidateBirthday(input, result);

        if (input.Sex is null)
        {
            result.Add(
                nameof(input.Sex),
                "Bitte wählen Sie ein Geschlecht aus.");
        }

        if (string.IsNullOrWhiteSpace(input.PrivateStreetName))
        {
            result.Add(
                nameof(input.PrivateStreetName),
                "Der Strassenname ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.PrivateStreetNumber))
        {
            result.Add(
                nameof(input.PrivateStreetNumber),
                "Die Hausnummer ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.PrivateCity))
        {
            result.Add(
                nameof(input.PrivateCity),
                "Der Wohnort ist erforderlich.");
        }
        


        return result;
    }
}