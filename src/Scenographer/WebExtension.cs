using ICSharpCode.SharpZipLib.Zip;

namespace Scenographer;

/// <summary>
/// WebExtension helper class.
/// </summary>
public static class WebExtension
{
    /// <summary>
    /// Unpacks a compressed WebExtension.
    /// </summary>
    /// <param name="source">Source path of WebExtension package.</param>
    /// <param name="destination">Destination path of target directory.</param>
    public static void Unpack(string source, string destination)
    {
        new FastZip().ExtractZip(source, destination, null);
    }
}