
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Redefine
    /// </summary>
    public enum EstimateGenRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        DustScratch,
        /// <summary>
        /// 
        /// </summary>
        DustScratchV2,
        /// <summary>
        /// 
        /// </summary>
        RecoveryV2,
        /// <summary>
        /// 
        /// </summary>
        Redefine,
        /// <summary>
        /// 
        /// </summary>
        StandardMax,
        /// <summary>
        /// 
        /// </summary>
        SuperFocusV2,
        /// <summary>
        /// 
        /// </summary>
        Wonder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateGenRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateGenRequestModel value)
        {
            return value switch
            {
                EstimateGenRequestModel.DustScratch => "Dust-Scratch",
                EstimateGenRequestModel.DustScratchV2 => "Dust-Scratch V2",
                EstimateGenRequestModel.RecoveryV2 => "Recovery V2",
                EstimateGenRequestModel.Redefine => "Redefine",
                EstimateGenRequestModel.StandardMax => "Standard MAX",
                EstimateGenRequestModel.SuperFocusV2 => "Super Focus V2",
                EstimateGenRequestModel.Wonder => "Wonder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateGenRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Dust-Scratch" => EstimateGenRequestModel.DustScratch,
                "Dust-Scratch V2" => EstimateGenRequestModel.DustScratchV2,
                "Recovery V2" => EstimateGenRequestModel.RecoveryV2,
                "Redefine" => EstimateGenRequestModel.Redefine,
                "Standard MAX" => EstimateGenRequestModel.StandardMax,
                "Super Focus V2" => EstimateGenRequestModel.SuperFocusV2,
                "Wonder" => EstimateGenRequestModel.Wonder,
                _ => null,
            };
        }
    }
}