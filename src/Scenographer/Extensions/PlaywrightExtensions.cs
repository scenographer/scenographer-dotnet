using Microsoft.Playwright;

namespace Scenographer;

/// <summary>
/// Extension methods for Playwright.
/// </summary>
public static class PlaywrightExtensions
{
    /// <summary>
    /// Configures the context to include WebExtensions.
    /// </summary>
    /// <param name="options">The options being used to configure the context.</param>
    /// <returns>The context options so that further configuration can be chained.</returns>
    public static BrowserTypeLaunchPersistentContextOptions UseWebExtensions(this BrowserTypeLaunchPersistentContextOptions options)
    {
        return options.UseWebExtensions(BrowserStorage.Default.ExtensionsDirectory);
    }

    /// <summary>
    /// Configures the context to include WebExtensions.
    /// </summary>
    /// <param name="options">The options being used to configure the context.</param>
    /// <param name="sourceDirectory">The source directory</param>
    /// <returns>The context options so that further configuration can be chained.</returns>
    public static BrowserTypeLaunchPersistentContextOptions UseWebExtensions(this BrowserTypeLaunchPersistentContextOptions options, string sourceDirectory)
    {
        const string separator = ",";

        options.Headless = false;
        options.Args = options.Args ?? Enumerable.Empty<string>();

        if (Directory.Exists(sourceDirectory))
        {
            var extensions = Directory.GetDirectories(sourceDirectory);

            var extensionsPath = extensions.Select(ext => Path.Combine(sourceDirectory, ext));
            var extensionsList = string.Join(separator, extensionsPath);

            options.Args = options.Args
                .Append($"--load-extension={extensionsList}")
                .Append($"--disable-extensions-except={extensionsList}");
        }

        return options;
    }
}