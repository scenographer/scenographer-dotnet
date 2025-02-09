namespace Scenographer;

/// <summary>
/// Extension methods for <see cref="T:Scenographer.BrowserStorage" />.
/// </summary>
public static class BrowserStorageExtensions
{
    /// <summary>
    /// Creates a browser feed to configure extensions.
    /// </summary>
    /// <param name="storage">Browser storage.</param>
    /// <param name="store">Web store.</param>
    /// <returns>Browser feed.</returns>
    public static IBrowserFeed UseFeed(this BrowserStorage storage, IWebStore store)
        => new BrowserFeed(storage, store);
}