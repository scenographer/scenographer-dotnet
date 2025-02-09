namespace Scenographer;

/// <summary>
/// Represent a web store for WebExtensions.
/// </summary>
public interface IWebStore
{
    /// <summary>
    /// Downloads a WebExtension.
    /// </summary>
    /// <param name="extensionId">The extension identifier.</param>
    /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <returns><see cref="T:System.Threading.Tasks.Task" /></returns>
    Task<Stream> DownloadAsync(string extensionId, CancellationToken cancellationToken = default);
}