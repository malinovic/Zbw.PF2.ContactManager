using System.Globalization;

using Zbw.PF2.ContactManager.Core.Validation;
using Zbw.PF2.ContactManager.Validation.ValidationEmployee;

namespace Zbw.PF2.ContactManager.Service.Validation;

/// <summary>
///     Validates an <see cref="EmployeeInput" /> and collects any validation failures.
/// </summary>
public sealed class EmployeeValidatorService
{
    private static void ValidateBirthday(
        EmployeeInput input,
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

    private static void ValidateDateOfHire(
        EmployeeInput input,
        ValidationResult result)
    {
        if (string.IsNullOrWhiteSpace(input.DateOfHire))
        {
            result.Add(
                nameof(input.DateOfHire),
                "Das Eintrittsdatum ist erforderlich.");

            return;
        }

        bool isValidDate = DateTime.TryParseExact(
            input.DateOfHire.Trim(),
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime dateOfHire);

        if (!isValidDate)
        {
            result.Add(
                nameof(input.DateOfHire),
                "Das Eintrittsdatum muss im Format TT.MM.JJJJ eingegeben werden.");

            return;
        }

        if (dateOfHire.Date > DateTime.Today)
        {
            result.Add(
                nameof(input.DateOfHire),
                "Das Eintrittsdatum darf nicht in der Zukunft liegen.");
        }
    }

    /// <summary>
    ///     Validates all fields of the given employee input.
    /// </summary>
    /// <param name="input">The employee input to validate.</param>
    /// <returns>A <see cref="ValidationResult" /> containing any validation failures.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="input" /> is <c>null</c>.</exception>
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

        // Private Adresse

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
        else if (!input.PrivateStreetNumber.Any(char.IsDigit))
        {
            result.Add(
                nameof(input.PrivateStreetNumber),
                "Die Hausnummer muss mindestens eine Zahl enthalten.");
        }

        if (string.IsNullOrWhiteSpace(input.PrivateZipCode))
        {
            result.Add(
                nameof(input.PrivateZipCode),
                "Die Postleitzahl ist erforderlich.");
        }
        else if (!input.PrivateZipCode.All(char.IsDigit))
        {
            result.Add(
                nameof(input.PrivateZipCode),
                "Die Postleitzahl darf nur Zahlen enthalten.");
        }

        if (string.IsNullOrWhiteSpace(input.PrivateCity))
        {
            result.Add(
                nameof(input.PrivateCity),
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

        // Mitarbeiterdaten

        if (string.IsNullOrWhiteSpace(input.EmployeeNumber))
        {
            result.Add(
                nameof(input.EmployeeNumber),
                "Die Mitarbeiternummer ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.Department))
        {
            result.Add(
                nameof(input.Department),
                "Die Abteilung ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.AhvNumber))
        {
            result.Add(
                nameof(input.AhvNumber),
                "Die AHV-Nummer ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.Nationality))
        {
            result.Add(
                nameof(input.Nationality),
                "Die Nationalität ist erforderlich.");
        }


        if (input.EmploymentRate < 1 || input.EmploymentRate > 100)
        {
            result.Add(
                nameof(input.EmploymentRate),
                "Das Arbeitspensum muss zwischen 1 und 100 Prozent liegen.");
        }

        if (string.IsNullOrWhiteSpace(input.Role))
        {
            result.Add(
                nameof(input.Role),
                "Die Rolle ist erforderlich.");
        }

        if (input.ApprenticeshipYears < 0)
        {
            result.Add(
                nameof(input.ApprenticeshipYears),
                "Die Anzahl Lehrjahre darf nicht negativ sein.");
        }

        if (input.EmployeeStatus is null)
        {
            result.Add(
                nameof(input.EmployeeStatus),
                "Bitte wählen Sie einen Mitarbeiterstatus aus.");
        }

        if (input.EmployeeSeniorLevel is null)
        {
            result.Add(
                nameof(input.EmployeeSeniorLevel),
                "Bitte wählen Sie ein Senioritätslevel aus.");
        }

        ValidateDateOfHire(input, result);

        if (string.IsNullOrWhiteSpace(input.WorkStreetName))
        {
            result.Add(
                nameof(input.WorkStreetName),
                "Der Strassenname der Arbeitsadresse ist erforderlich.");
        }

        if (string.IsNullOrWhiteSpace(input.WorkStreetNumber))
        {
            result.Add(
                nameof(input.WorkStreetNumber),
                "Die Hausnummer der Arbeitsadresse ist erforderlich.");
        }
        else if (!input.WorkStreetNumber.Any(char.IsDigit))
        {
            result.Add(
                nameof(input.WorkStreetNumber),
                "Die Hausnummer der Arbeitsadresse muss mindestens eine Zahl enthalten.");
        }

        if (string.IsNullOrWhiteSpace(input.WorkZipCode))
        {
            result.Add(
                nameof(input.WorkZipCode),
                "Die Postleitzahl der Arbeitsadresse ist erforderlich.");
        }
        else if (!input.WorkZipCode.All(char.IsDigit))
        {
            result.Add(
                nameof(input.WorkZipCode),
                "Die Postleitzahl der Arbeitsadresse darf nur Zahlen enthalten.");
        }

        if (string.IsNullOrWhiteSpace(input.WorkCity))
        {
            result.Add(
                nameof(input.WorkCity),
                "Der Ort der Arbeitsadresse ist erforderlich.");
        }

        return result;
    }
}