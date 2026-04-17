
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Object
    /// </summary>
    public enum MattingGANRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MattingGANRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MattingGANRequestModel value)
        {
            return value switch
            {
                MattingGANRequestModel.Object => "Object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MattingGANRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Object" => MattingGANRequestModel.Object,
                _ => null,
            };
        }
    }
}