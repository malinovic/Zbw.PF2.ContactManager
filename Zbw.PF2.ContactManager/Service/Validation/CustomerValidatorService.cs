using System.Globalization;

using Zbw.PF2.ContactManager.Core.Validation;
using Zbw.PF2.ContactManager.Validation.ValidationCustomer;

namespace Zbw.PF2.ContactManager.Service.Validation;

/// <summary>
///     Validates a <see cref="CustomerInput" /> and collects any validation failures.
/// </summary>
public sealed class CustomerValidatorService
{
    private static void ValidateBirthday(
        CustomerInput input,
        ValidationResult result)
    {
        if (string.IsNullOrWhiteSpace(input.Birthday))
        {
            result.Add(
                nameof(input.Birthday),
                "Das Geburtsdatum ist erforderlich.");

            return;
        }

        bool isValidDate = DateTime.TryParseExact(
            input.Birthday.Trim(),
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime birthday);

        if (!isValidDate)
        {
            result.Add(
                nameof(input.Birthday),
                "Das Geburtsdatum muss im Format TT.MM.JJJJ eingegeben werden.");

            return;
        }

        if (birthday.Date > DateTime.Today)
        {
            result.Add(
                nameof(input.Birthday),
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
            result.Add(
                nameof(input.Birthday),
                "Das Geburtsdatum ist nicht plausibel.");
        }
    }

    /// <summary>
    ///     Validates all fields of the given customer input.
    /// </summary>
    /// <param name="input">The customer input to validate.</param>
    /// <returns>A <see cref="ValidationResult" /> containing any validation failures.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="input" /> is <c>null</c>.</exception>
    public ValidationResult Validate(CustomerInput input)
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
            result.Add(
                nameof(input.FirstName),
                "Der Vorname ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.LastName))
        {
            result.Add(
                nameof(input.LastName),
                "Der Nachname ist erforderlich.");
        }

        ValidateBirthday(input, result);

        if (input.Sex is null)
        {
            result.Add(
                nameof(input.Sex),
                "Bitte wählen Sie ein Geschlecht aus.");
        }

        // Adresse

        if (string.IsNullOrWhiteSpace(input.StreetName))
        {
            result.Add(
                nameof(input.StreetName),
                "Der Strassenname ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.StreetNumber))
        {
            result.Add(
                nameof(input.StreetNumber),
                "Die Hausnummer ist erforderlich.");
        }
        else if (!input.StreetNumber.Any(char.IsDigit))
        {
            result.Add(
                nameof(input.StreetNumber),
                "Die Hausnummer muss mindestens eine Zahl enthalten.");
        }

        if (string.IsNullOrWhiteSpace(input.ZipCode))
        {
            result.Add(
                nameof(input.ZipCode),
                "Die Postleitzahl ist erforderlich.");
        }
        else if (!input.ZipCode.All(char.IsDigit))
        {
            result.Add(
                nameof(input.ZipCode),
                "Die Postleitzahl darf nur Zahlen enthalten.");
        }

        if (string.IsNullOrWhiteSpace(input.City))
        {
            result.Add(
                nameof(input.City),
                "Der Wohnort ist erforderlich.");
        }

        // Kontaktdaten

        if (input.PhoneNumberCompany != string.Empty && !ValidationFormats.PhoneRegex.IsMatch(input.PhoneNumberCompany))
        {
            result.Add(
                nameof(input.PhoneNumberCompany),
                "Die geschäftliche Telefonnummer darf nur Zahlen enthalten.");
        }

        if (!string.IsNullOrWhiteSpace(input.PhoneNumberMobile)
            && !ValidationFormats.PhoneRegex.IsMatch(input.PhoneNumberMobile))
        {
            result.Add(
                nameof(input.PhoneNumberMobile),
                "Die mobile Telefonnummer darf nur Zahlen enthalten.");
        }

        if (string.IsNullOrWhiteSpace(input.Email))
        {
            result.Add(
                nameof(input.Email),
                "Die E-Mail-Adresse ist erforderlich.");
        }
        else if (!ValidationFormats.EmailRegex.IsMatch(input.Email))
        {
            result.Add(
                nameof(input.Email),
                "Bitte geben Sie eine gültige E-Mail-Adresse ein.");
        }

        // Kundendaten

        if (string.IsNullOrWhiteSpace(input.CustomerNumber))
        {
            result.Add(
                nameof(input.CustomerNumber),
                "Die Kundennummer ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.CustomerCompanyName))
        {
            result.Add(
                nameof(input.CustomerCompanyName),
                "Der Firmenname ist erforderlich.");
        }

        if (input.CustomerStatus is null)
        {
            result.Add(
                nameof(input.CustomerStatus),
                "Bitte wählen Sie einen Kundenstatus aus.");
        }

        if (input.CustomerType is null)
        {
            result.Add(
                nameof(input.CustomerType),
                "Bitte wählen Sie einen Kundentyp aus.");
        }

        return result;
    }
}