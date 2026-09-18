using System.Diagnostics;

namespace Zbw.PF2.ContactManager.Core.Setup;

/// <summary>
///     Tracks and coordinates the one-time initialization of the application.
/// </summary>
internal static class Setup
{
    private static bool _isInitialized = false;

    /// <summary>
    ///     Checks whether the application has already been initialized.
    /// </summary>
    /// <returns><c>true</c> if <see cref="InitializeApp" /> has already run successfully; otherwise <c>false</c>.</returns>
    public static bool CheckHealth()
    {
        if (_isInitialized) return true;

        return false;
    }

    /// <summary>
    ///     Performs the application's one-time startup initialization. Calling this more than once
    ///     has no effect beyond the first successful call.
    /// </summary>
    /// <returns><c>true</c> if initialization ran for the first time; <c>false</c> if it had already run.</returns>
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
