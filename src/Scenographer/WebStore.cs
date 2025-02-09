using Scenographer.Stores;

namespace Scenographer;

/// <summary>
/// Catalog of available web stores
/// </summary>
public static class WebStore
{
    /// <summary>
    /// Chrome web store
    /// </summary>
    public static IWebStore Chrome { get; }

    /// <summary>
    /// Local store
    /// </summary>
    public static IWebStore Local { get; }

    static WebStore()
    {
        Chrome = new ChromeWebStore();
        Local = new LocalWebStore();
    }
}