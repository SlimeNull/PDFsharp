// MigraDoc - Creating Documents on the Fly
// See the LICENSE file in the solution root for more information.

using PdfSharp.Internal;

namespace MigraDoc.RtfRendering
{
    enum MdRtfMsgId
    {
        None = 0,

        UpdateField = MessageIdOffset.MdRtf,
        TextFrameContentsNotTurned,
        InvalidNumericFieldFormat,
        ImageFreelyPlacedInWrongContext,
        ChartFreelyPlacedInWrongContext,
        ImageNotFound,
        ImageNotReadable,
        ImageTypeNotSupported,
        CharacterNotAllowedInDateFormat
    }

    /// <summary>
    /// Provides diagnostic messages taken from the resources.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    class MdRtfMsgs
    {
        internal static string TextFrameContentsNotTurned
            => "Text-frame contents could not be turned. Only paragraphs can be turned within text-frames.";

        internal static string ImageFreelyPlacedInWrongContext(string imageName)
            => $"Images can be placed freely only within headers, footers and sections. Image {imageName} will be ignored.";

        internal static string ChartFreelyPlacedInWrongContext
            => "Chart is being ignored. A chart can be placed freely only within headers, footers and sections.";

        internal static string ImageNotFound(string imageName)
            => $"Image '{imageName}' could not be found.";

        internal static string ImageNotReadable(string imageName, string innerException)
            => $"Image '{imageName}' could not be read. Inner Exception:\r\n{innerException}.";

        internal static string ImageTypeNotSupported(string imageName)
            => $"Type of image '{imageName}' is not supported.";

        internal static string InvalidNumericFieldFormat(string format)
            => $"'{format}' is not a valid format for a numeric field and will be ignored.";

        internal static string CharacterNotAllowedInDateFormat(char character)
            => $"The character '{character}' is not allowed in a date field’s format string and will be ignored.";

        internal static string UpdateField
            => "< Please update this field. >";

        // ReSharper disable InconsistentNaming
    }
}
