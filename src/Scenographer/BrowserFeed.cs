using ICSharpCode.SharpZipLib.Zip;

namespace Scenographer;

/// <inheritdoc />
public class BrowserFeed : IBrowserFeed
{
    private readonly BrowserStorage _storage;

    private readonly IWebStore _store;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Scenographer.BrowserFeed" /> class.
    /// </summary>
    /// <param name="storage">Browser storage.</param>
    /// <param name="store">Web store.</param>
    public BrowserFeed(BrowserStorage storage, IWebStore store)
    {
        _storage = storage;
        _store = store;
    }

    /// <inheritdoc />
    public async Task InstallExtensionAsync(string extensionId, CancellationToken cancellationToken = default)
    {
        var destination = Path.Combine(_storage.ExtensionsDirectory, extensionId);

        if (Directory.Exists(destination)) return;

        using var download = await _store.DownloadAsync(extensionId);

        using var ms = new MemoryStream();
        await download.CopyToAsync(ms);

        new FastZip().ExtractZip(ms, destination);
    }
}