
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The container format of the video file<br/>
    /// Example: mp4
    /// </summary>
    public enum CreateExpressVideoRequestRequestSourceContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Mkv,
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressVideoRequestRequestSourceContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressVideoRequestRequestSourceContainer value)
        {
            return value switch
            {
                CreateExpressVideoRequestRequestSourceContainer.Mkv => "mkv",
                CreateExpressVideoRequestRequestSourceContainer.Mov => "mov",
                CreateExpressVideoRequestRequestSourceContainer.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressVideoRequestRequestSourceContainer? ToEnum(string value)
        {
            return value switch
            {
                "mkv" => CreateExpressVideoRequestRequestSourceContainer.Mkv,
                "mov" => CreateExpressVideoRequestRequestSourceContainer.Mov,
                "mp4" => CreateExpressVideoRequestRequestSourceContainer.Mp4,
                _ => null,
            };
        }
    }
}