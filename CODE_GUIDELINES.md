# Code Guidelines – Contact Manager

These guidelines apply to all team members so the codebase stays consistent, readable, and maintainable despite being split across 3 people.

## 1. Language

- **Code (class, method, variable names):** English
- **Comments & XML documentation:** English
- **UI texts (labels, buttons, messages):** German (Swiss customers)

## 2. Naming Conventions

| Element | Convention | Example |
|---|---|---|
| Classes, structs, enums | PascalCase | `Customer`, `Employee`, `ContactNote` |
| Interfaces | `I` + PascalCase | `ISaveable`, `ISearchable` |
| Methods | PascalCase, verb | `SaveAll()`, `SearchByName()` |
| Properties | PascalCase | `FirstName`, `EmployeeNumber` |
| Local variables, parameters | camelCase | `customerList`, `searchTerm` |
| Private fields | `_camelCase` | `_customers`, `_logger` |
| Constants | PascalCase or UPPER_CASE | `MaxManagementLevel`, `DATA_FILE_PATH` |
| File names | = class name | `Customer.cs`, `EmployeeForm.cs` |

No abbreviations except common ones (`Id`, `No`). Prefer descriptive names over comments.

## 3. Architecture

- Inheritance hierarchy is **mandatory**: `Person` (abstract) → `Customer`, `Employee`
- Clear separation into layers:
  - **Models** – pure data classes (no UI logic)
  - **Services** – business logic, data access, save/load, search
  - **Forms** – UI logic only, calls into services
- Each class has a single, clear responsibility (Single Responsibility). No "god classes".
- No direct file/persistence logic inside the Forms.

## 4. Documentation (XML Doc Comments)

All **public** classes, methods, properties and constructors require XML doc comments (`///`):

```csharp
/// <summary>
/// Represents a customer of the company.
/// </summary>
public class Customer : Person
{
    /// <summary>
    /// Current status of the customer (active/inactive).
    /// </summary>
    public CustomerStatus Status { get; set; }

    /// <summary>
    /// Adds a new contact note to the customer's history.
    /// </summary>
    /// <param name="note">The note to log.</param>
    public void AddNote(ContactNote note) { ... }
}
```

## 5. Formatting

- Standard C# conventions (Visual Studio default formatting, `Ctrl+K, Ctrl+D` before every commit)
- 4 spaces indentation, no tabs
- Curly braces on their own line (Allman style)
- One class per file
- `using` statements at the top of the file, sorted alphabetically, unused ones removed

## 6. Error Handling & Validation

- **Always validate** user input before writing it to models (e.g. date formats, required fields, AHV number format)
- No uncaught exceptions that crash the app
- Error messages shown to users should be understandable and in German
- Use `try-catch` only where meaningful handling is possible – not to swallow errors silently

## 7. Git Workflow

- **main**: always in a working state
- **Feature branches**: `feature/<short-description>` (e.g. `feature/customer-crud`)
- Commit messages in English, imperative mood: `Add customer search`, `Fix saving when data store is empty`
- Pull request before merging into `main`, at least 1 review by another team member
- Small, frequent commits instead of large bulk commits

## 8. Code Review Checklist

- [ ] Compiles without warnings
- [ ] Naming conventions followed
- [ ] XML documentation present for public members
- [ ] No magic numbers / hardcoded strings (use constants)
- [ ] Input is validated
- [ ] No dead code / commented-out code left behind
