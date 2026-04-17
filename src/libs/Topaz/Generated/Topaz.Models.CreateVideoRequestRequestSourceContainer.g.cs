
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The container format of the video file<br/>
    /// Example: mp4
    /// </summary>
    public enum CreateVideoRequestRequestSourceContainer
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
    public static class CreateVideoRequestRequestSourceContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestRequestSourceContainer value)
        {
            return value switch
            {
                CreateVideoRequestRequestSourceContainer.Mkv => "mkv",
                CreateVideoRequestRequestSourceContainer.Mov => "mov",
                CreateVideoRequestRequestSourceContainer.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestRequestSourceContainer? ToEnum(string value)
        {
            return value switch
            {
                "mkv" => CreateVideoRequestRequestSourceContainer.Mkv,
                "mov" => CreateVideoRequestRequestSourceContainer.Mov,
                "mp4" => CreateVideoRequestRequestSourceContainer.Mp4,
                _ => null,
            };
        }
    }
}