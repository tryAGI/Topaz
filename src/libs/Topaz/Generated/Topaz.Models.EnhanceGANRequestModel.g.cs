
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Standard V2
    /// </summary>
    public enum EnhanceGANRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Cgi,
        /// <summary>
        /// 
        /// </summary>
        HighFidelityV2,
        /// <summary>
        /// 
        /// </summary>
        LowResolutionV2,
        /// <summary>
        /// 
        /// </summary>
        StandardV2,
        /// <summary>
        /// 
        /// </summary>
        TextRefine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnhanceGANRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhanceGANRequestModel value)
        {
            return value switch
            {
                EnhanceGANRequestModel.Cgi => "CGI",
                EnhanceGANRequestModel.HighFidelityV2 => "High Fidelity V2",
                EnhanceGANRequestModel.LowResolutionV2 => "Low Resolution V2",
                EnhanceGANRequestModel.StandardV2 => "Standard V2",
                EnhanceGANRequestModel.TextRefine => "Text Refine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhanceGANRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "CGI" => EnhanceGANRequestModel.Cgi,
                "High Fidelity V2" => EnhanceGANRequestModel.HighFidelityV2,
                "Low Resolution V2" => EnhanceGANRequestModel.LowResolutionV2,
                "Standard V2" => EnhanceGANRequestModel.StandardV2,
                "Text Refine" => EnhanceGANRequestModel.TextRefine,
                _ => null,
            };
        }
    }
}