using System.Diagnostics;

namespace Zbw.PF2.ContactManager.Core.Setup;

/// <summary>
///     Handles one-time application startup initialization and tracks whether it has already run.
/// </summary>
internal static class Setup
{
    private static bool _isInitialized = false;

    /// <summary>
    ///     Checks whether the application has already been initialized.
    /// </summary>
    /// <returns><c>true</c> if <see cref="InitializeApp" /> has already run successfully; otherwise, <c>false</c>.</returns>
    public static bool CheckHealth()
    {
        if (_isInitialized) return true;

        return false;
    }

    /// <summary>
    ///     Performs the application's one-time startup initialization. Calling this more than once
    ///     has no effect and logs a warning.
    /// </summary>
    /// <returns><c>true</c> if initialization ran successfully; <c>false</c> if it had already run before.</returns>
    public static bool InitializeApp()
    {
        if (_isInitialized)
        {
            Debug.WriteLine("WARNING: Initialize has been called after the first time.");
            return false;
        }

        _isInitialized = true;


        return true;
    }
}