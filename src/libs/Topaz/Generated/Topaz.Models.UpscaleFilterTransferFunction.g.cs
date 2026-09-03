
#nullable enable

namespace Topaz
{
    /// <summary>
    /// HDR transfer function. Applies to the Hyperion model (`hyp-1`).<br/>
    /// Example: pq
    /// </summary>
    public enum UpscaleFilterTransferFunction
    {
        /// <summary>
        ///
        /// </summary>
        Hlg,
        /// <summary>
        ///
        /// </summary>
        Pq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleFilterTransferFunctionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFilterTransferFunction value)
        {
            return value switch
            {
                UpscaleFilterTransferFunction.Hlg => "hlg",
                UpscaleFilterTransferFunction.Pq => "pq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFilterTransferFunction? ToEnum(string value)
        {
            return value switch
            {
                "hlg" => UpscaleFilterTransferFunction.Hlg,
                "pq" => UpscaleFilterTransferFunction.Pq,
                _ => null,
            };
        }
    }
}