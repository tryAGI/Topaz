
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: png
    /// </summary>
    public enum MattingGANRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MattingGANRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MattingGANRequestOutputFormat value)
        {
            return value switch
            {
                MattingGANRequestOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MattingGANRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => MattingGANRequestOutputFormat.Png,
                _ => null,
            };
        }
    }
}