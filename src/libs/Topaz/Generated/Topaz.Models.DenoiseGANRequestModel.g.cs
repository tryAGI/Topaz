
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Normal
    /// </summary>
    public enum DenoiseGANRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Extreme,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Strong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DenoiseGANRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DenoiseGANRequestModel value)
        {
            return value switch
            {
                DenoiseGANRequestModel.Extreme => "Extreme",
                DenoiseGANRequestModel.Normal => "Normal",
                DenoiseGANRequestModel.Strong => "Strong",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DenoiseGANRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Extreme" => DenoiseGANRequestModel.Extreme,
                "Normal" => DenoiseGANRequestModel.Normal,
                "Strong" => DenoiseGANRequestModel.Strong,
                _ => null,
            };
        }
    }
}