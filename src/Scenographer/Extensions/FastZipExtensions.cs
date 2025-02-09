using ICSharpCode.SharpZipLib.Zip;

namespace Scenographer;

internal static class FastZipExtensions
{
    public static void ExtractZip(this FastZip zip, Stream inputStream, string targetDirectorye, string? fileFilter = null)
        => zip.ExtractZip(
            inputStream,
            targetDirectorye,
            FastZip.Overwrite.Always,
            null,
            fileFilter,
            null,
            true,
            true
        );
}