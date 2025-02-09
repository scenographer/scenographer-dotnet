namespace Scenographer;

/// <summary>
/// Represents a browser feed for WebExtensions.
/// </summary>
public interface IBrowserFeed
{
    /// <summary>
    /// Installs a WebExtension.
    /// </summary>
    /// <param name="extensionId">The extension identifier.</param>
    /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <returns><see cref="T:System.Threading.Tasks.Task" /></returns>
    Task InstallExtensionAsync(string extensionId, CancellationToken cancellationToken = default);
}