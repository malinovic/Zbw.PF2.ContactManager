using System;
using System.Collections.Generic;
using System.Text;

namespace Zbw.PF2.ContactManager.Core.Constants;

/// <summary>
///     Represents whether a customer or employee is currently active.
/// </summary>
public enum Status
{
    /// <summary>The contact is currently active.</summary>
    Active,
    /// <summary>The contact is currently passive/inactive.</summary>
    Passive,
}
