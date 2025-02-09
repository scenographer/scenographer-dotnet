namespace Scenographer.Stores;

/// <summary>
/// Represents a web store using Chrome Web Store.
/// </summary>
public class ChromeWebStore : IWebStore
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Scenographer.Stores.ChromeWebStore" /> class.
    /// </summary>
    public ChromeWebStore()
    {
        _httpClient = new HttpClient();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Scenographer.Stores.ChromeWebStore" /> class.
    /// </summary>
    /// <param name="httpClient">Http client to use.</param>
    public ChromeWebStore(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <inheritdoc />
    public async Task<Stream> DownloadAsync(string extensionId, CancellationToken cancellationToken = default)
    {
        const string prodversion = "49.0";
        string url = $"https://clients2.google.com/service/update2/crx?response=redirect&prodversion={prodversion}&acceptformat=crx3&x=id%3D{extensionId}%26installsource%3Dondemand%26uc";

        return await _httpClient.GetStreamAsync(url);
    }
}