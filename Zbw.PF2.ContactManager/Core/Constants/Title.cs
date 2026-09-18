using System;
using System.Collections.Generic;
using System.Text;

namespace Zbw.PF2.ContactManager.Core.Constants;

/// <summary>
///     Represents an academic title held by a contact.
/// </summary>
public enum Title
{
    /// <summary>No academic title.</summary>
    None,
    /// <summary>Doctor ("Dr.").</summary>
    Dr,
    /// <summary>Professor ("Prof.").</summary>
    Prof,
    /// <summary>Professor and doctor ("Prof. Dr.").</summary>
    ProfDr
}
