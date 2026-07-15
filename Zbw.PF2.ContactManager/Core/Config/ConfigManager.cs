using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Zbw.PF2.ContactManager.Core.Config;

/// <summary>
/// Represents the configuration manager for the Contact Manager application.
/// This class is a basic abstraction for managing application configuration settings, such as CSV file paths, etc.
/// The configuration settings are stored in the application's configuration file (app.config) and can be accessed through this class.
/// It provides a centralized way to retrieve configuration values, ensuring that the application can easily adapt to different environments and configurations without hardcoding values.
/// </summary>
public static class ConfigManager
{
    public static string CSV_DIRECTORY
    {
        get
        {
            return ConfigurationManager.AppSettings["CSV_DIRECTORY"] ?? throw new InvalidOperationException("CSV_DIRECTORY setting is not configured.");
        }
    }
}
