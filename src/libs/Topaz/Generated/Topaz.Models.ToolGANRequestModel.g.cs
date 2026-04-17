
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Transparency Upscale
    /// </summary>
    public enum ToolGANRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        TransparencyUpscale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolGANRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolGANRequestModel value)
        {
            return value switch
            {
                ToolGANRequestModel.TransparencyUpscale => "Transparency Upscale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolGANRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Transparency Upscale" => ToolGANRequestModel.TransparencyUpscale,
                _ => null,
            };
        }
    }
}