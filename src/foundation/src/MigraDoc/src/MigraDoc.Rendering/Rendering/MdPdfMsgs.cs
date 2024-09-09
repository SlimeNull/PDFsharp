// MigraDoc - Creating Documents on the Fly
// See the LICENSE file in the solution root for more information.

using PdfSharp.Internal;

namespace MigraDoc.Rendering
{
    /// <summary>
    /// MigraDoc PDF renderer message id.
    /// </summary>
    // ReSharper disable InconsistentNaming
    enum MdPdfMsgId
    {
        PropertyNotSetBefore = MessageIdOffset.MdPdf,
        BookmarkNotDefined,
        ImageNotFound,
        InvalidImageType,
        ImageNotReadable,
        EmptyImageSize,
        ObjectNotRenderable,
        NumberTooLargeForRoman,
        NumberTooLargeForLetters,
        DisplayEmptyImageSize,
        DisplayImageFileNotFound,
        DisplayInvalidImageType,
        DisplayImageNotRead
    }

    // ReSharper restore InconsistentNaming

    /// <summary>
    /// MigraDoc PDF renderer messages.
    /// Provides diagnostic messages taken from the resources.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    static class MdPdfMsgs
    {
        internal static string NumberTooLargeForRoman(int number)
            => $"The number {number} is to large to be displayed as roman number.";

        internal static string NumberTooLargeForLetters(int number)
            => $"The number {number} is to large to be displayed as letters.";

        internal static string DisplayEmptyImageSize
            => "Image has empty size.";

        internal static string DisplayImageFileNotFound(string fileName)
            => $"Image '{fileName}' not found.";

        internal static string DisplayInvalidImageType
            => "Image has no valid type.";

        internal static string DisplayImageNotRead
            => "Image could not be read.";

        internal static string PropertyNotSetBefore(string propertyName, string functionName)
            => "'{propertyName}' must be set before calling '{functionName}'.";

        internal static string BookmarkNotDefined(string bookmarkName)
            => $"Bookmark '{bookmarkName}' is not defined within the document.";

        internal static string ImageNotFound(string imageName)
            => $"Image '{imageName}' not found.";

        internal static string InvalidImageType(string type)
            => $"Invalid image type: '{type}'.";

        internal static string ImageNotReadable(string imageName, string innerException)
            => $"Image '{imageName}' could not be read.\\n Inner exception: {innerException}";

        internal static string EmptyImageSize
            => "The specified image size is empty.";

        internal static string ObjectNotRenderable(string typeName)
            => "Only images, text-frames, charts and paragraphs can be rendered freely.";
    }
}
