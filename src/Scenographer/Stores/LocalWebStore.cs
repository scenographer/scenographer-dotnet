namespace Scenographer.Stores;

/// <summary>
/// Represents a web store using the file system.
/// </summary>
public class LocalWebStore : IWebStore
{
    private readonly string _baseDirectory;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Scenographer.Stores.LocalWebStore" /> class.
    /// </summary>
    public LocalWebStore()
    {
        _baseDirectory = Path.Combine(AppContext.BaseDirectory, ".webextensions");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Scenographer.Stores.LocalWebStore" /> class.
    /// </summary>
    /// <param name="baseDirectory">Base directory of browser storage.</param>
    public LocalWebStore(string baseDirectory)
    {
        _baseDirectory = baseDirectory;
    }

    /// <inheritdoc />
    public Task<Stream> DownloadAsync(string extensionId, CancellationToken cancellationToken = default)
    {
        var filename = $"{extensionId}.crx";
        var path = Path.Combine(_baseDirectory, filename);

        var fs = File.OpenRead(path);

        return Task.FromResult<Stream>(fs);
    }
}