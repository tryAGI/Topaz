
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The container format of the video file. Matched case-insensitively.<br/>
    /// Example: mp4
    /// </summary>
    public enum CreateVideoRequestRequestSourceContainer
    {
        /// <summary>
        ///
        /// </summary>
        x3gp,
        /// <summary>
        ///
        /// </summary>
        Avi,
        /// <summary>
        ///
        /// </summary>
        Dv,
        /// <summary>
        ///
        /// </summary>
        Flv,
        /// <summary>
        ///
        /// </summary>
        M1v,
        /// <summary>
        ///
        /// </summary>
        M2t,
        /// <summary>
        ///
        /// </summary>
        M2ts,
        /// <summary>
        ///
        /// </summary>
        M2v,
        /// <summary>
        ///
        /// </summary>
        M4v,
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
        /// <summary>
        ///
        /// </summary>
        Mpeg,
        /// <summary>
        ///
        /// </summary>
        Mpg,
        /// <summary>
        ///
        /// </summary>
        Mts,
        /// <summary>
        ///
        /// </summary>
        Mxf,
        /// <summary>
        ///
        /// </summary>
        Ser,
        /// <summary>
        ///
        /// </summary>
        Ts,
        /// <summary>
        ///
        /// </summary>
        Vob,
        /// <summary>
        ///
        /// </summary>
        Webm,
        /// <summary>
        ///
        /// </summary>
        Wmv,
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
                CreateVideoRequestRequestSourceContainer.x3gp => "3gp",
                CreateVideoRequestRequestSourceContainer.Avi => "avi",
                CreateVideoRequestRequestSourceContainer.Dv => "dv",
                CreateVideoRequestRequestSourceContainer.Flv => "flv",
                CreateVideoRequestRequestSourceContainer.M1v => "m1v",
                CreateVideoRequestRequestSourceContainer.M2t => "m2t",
                CreateVideoRequestRequestSourceContainer.M2ts => "m2ts",
                CreateVideoRequestRequestSourceContainer.M2v => "m2v",
                CreateVideoRequestRequestSourceContainer.M4v => "m4v",
                CreateVideoRequestRequestSourceContainer.Mkv => "mkv",
                CreateVideoRequestRequestSourceContainer.Mov => "mov",
                CreateVideoRequestRequestSourceContainer.Mp4 => "mp4",
                CreateVideoRequestRequestSourceContainer.Mpeg => "mpeg",
                CreateVideoRequestRequestSourceContainer.Mpg => "mpg",
                CreateVideoRequestRequestSourceContainer.Mts => "mts",
                CreateVideoRequestRequestSourceContainer.Mxf => "mxf",
                CreateVideoRequestRequestSourceContainer.Ser => "ser",
                CreateVideoRequestRequestSourceContainer.Ts => "ts",
                CreateVideoRequestRequestSourceContainer.Vob => "vob",
                CreateVideoRequestRequestSourceContainer.Webm => "webm",
                CreateVideoRequestRequestSourceContainer.Wmv => "wmv",
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
                "3gp" => CreateVideoRequestRequestSourceContainer.x3gp,
                "avi" => CreateVideoRequestRequestSourceContainer.Avi,
                "dv" => CreateVideoRequestRequestSourceContainer.Dv,
                "flv" => CreateVideoRequestRequestSourceContainer.Flv,
                "m1v" => CreateVideoRequestRequestSourceContainer.M1v,
                "m2t" => CreateVideoRequestRequestSourceContainer.M2t,
                "m2ts" => CreateVideoRequestRequestSourceContainer.M2ts,
                "m2v" => CreateVideoRequestRequestSourceContainer.M2v,
                "m4v" => CreateVideoRequestRequestSourceContainer.M4v,
                "mkv" => CreateVideoRequestRequestSourceContainer.Mkv,
                "mov" => CreateVideoRequestRequestSourceContainer.Mov,
                "mp4" => CreateVideoRequestRequestSourceContainer.Mp4,
                "mpeg" => CreateVideoRequestRequestSourceContainer.Mpeg,
                "mpg" => CreateVideoRequestRequestSourceContainer.Mpg,
                "mts" => CreateVideoRequestRequestSourceContainer.Mts,
                "mxf" => CreateVideoRequestRequestSourceContainer.Mxf,
                "ser" => CreateVideoRequestRequestSourceContainer.Ser,
                "ts" => CreateVideoRequestRequestSourceContainer.Ts,
                "vob" => CreateVideoRequestRequestSourceContainer.Vob,
                "webm" => CreateVideoRequestRequestSourceContainer.Webm,
                "wmv" => CreateVideoRequestRequestSourceContainer.Wmv,
                _ => null,
            };
        }
    }
}