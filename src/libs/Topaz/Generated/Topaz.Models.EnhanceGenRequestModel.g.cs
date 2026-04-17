
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Redefine
    /// </summary>
    public enum EnhanceGenRequestModel
    {
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
        Wonder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnhanceGenRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhanceGenRequestModel value)
        {
            return value switch
            {
                EnhanceGenRequestModel.RecoveryV2 => "Recovery V2",
                EnhanceGenRequestModel.Redefine => "Redefine",
                EnhanceGenRequestModel.StandardMax => "Standard MAX",
                EnhanceGenRequestModel.Wonder => "Wonder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhanceGenRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Recovery V2" => EnhanceGenRequestModel.RecoveryV2,
                "Redefine" => EnhanceGenRequestModel.Redefine,
                "Standard MAX" => EnhanceGenRequestModel.StandardMax,
                "Wonder" => EnhanceGenRequestModel.Wonder,
                _ => null,
            };
        }
    }
}