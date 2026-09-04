using System.Diagnostics;

namespace Zbw.PF2.ContactManager.Core.Setup;

internal static class Setup
{
    private static bool _isInitialized = false;

    public static bool CheckHealth()
    {
        if (_isInitialized) return true;

        return false;
    }

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
