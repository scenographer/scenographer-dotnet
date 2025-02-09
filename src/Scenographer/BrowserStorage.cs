namespace Scenographer;

/// <summary>
/// Represents a browser storage. It can be used to place profiles.
/// </summary>
public class BrowserStorage
{
    private const string DefaultFolder = ".browser";

    private const string ExtensionsFolder = "Extensions";

    /// <summary>
    /// Gets the default browser storage.
    /// </summary>
    public static BrowserStorage Default { get; } = new();

    /// <summary>
    /// Gets the base directory of browser storage.
    /// </summary>
    public string BaseDirectory { get; }

    /// <summary>
    /// Gets the extensions directory of browser storage.
    /// </summary>
    public string ExtensionsDirectory { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Scenographer.BrowserStorage" /> class.
    /// </summary>
    public BrowserStorage()
    {
        BaseDirectory = Path.Combine(AppContext.BaseDirectory, DefaultFolder);

        ExtensionsDirectory = Path.Combine(BaseDirectory, ExtensionsFolder);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Scenographer.BrowserStorage" /> class.
    /// </summary>
    /// <param name="baseDirectory">Base directory of browser storage.</param>
    public BrowserStorage(string baseDirectory)
    {
        BaseDirectory = baseDirectory;

        ExtensionsDirectory = Path.Combine(BaseDirectory, ExtensionsFolder);
    }
}