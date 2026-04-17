
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: png
    /// </summary>
    public enum ToolGANRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolGANRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolGANRequestOutputFormat value)
        {
            return value switch
            {
                ToolGANRequestOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolGANRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => ToolGANRequestOutputFormat.Png,
                _ => null,
            };
        }
    }
}