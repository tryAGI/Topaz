
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The container format of the video file. Matched case-insensitively.<br/>
    /// Example: mp4
    /// </summary>
    public enum CreateExpressVideoRequestRequestSourceContainer
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
    public static class CreateExpressVideoRequestRequestSourceContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressVideoRequestRequestSourceContainer value)
        {
            return value switch
            {
                CreateExpressVideoRequestRequestSourceContainer.x3gp => "3gp",
                CreateExpressVideoRequestRequestSourceContainer.Avi => "avi",
                CreateExpressVideoRequestRequestSourceContainer.Dv => "dv",
                CreateExpressVideoRequestRequestSourceContainer.Flv => "flv",
                CreateExpressVideoRequestRequestSourceContainer.M1v => "m1v",
                CreateExpressVideoRequestRequestSourceContainer.M2t => "m2t",
                CreateExpressVideoRequestRequestSourceContainer.M2ts => "m2ts",
                CreateExpressVideoRequestRequestSourceContainer.M2v => "m2v",
                CreateExpressVideoRequestRequestSourceContainer.M4v => "m4v",
                CreateExpressVideoRequestRequestSourceContainer.Mkv => "mkv",
                CreateExpressVideoRequestRequestSourceContainer.Mov => "mov",
                CreateExpressVideoRequestRequestSourceContainer.Mp4 => "mp4",
                CreateExpressVideoRequestRequestSourceContainer.Mpeg => "mpeg",
                CreateExpressVideoRequestRequestSourceContainer.Mpg => "mpg",
                CreateExpressVideoRequestRequestSourceContainer.Mts => "mts",
                CreateExpressVideoRequestRequestSourceContainer.Mxf => "mxf",
                CreateExpressVideoRequestRequestSourceContainer.Ser => "ser",
                CreateExpressVideoRequestRequestSourceContainer.Ts => "ts",
                CreateExpressVideoRequestRequestSourceContainer.Vob => "vob",
                CreateExpressVideoRequestRequestSourceContainer.Webm => "webm",
                CreateExpressVideoRequestRequestSourceContainer.Wmv => "wmv",
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
                "3gp" => CreateExpressVideoRequestRequestSourceContainer.x3gp,
                "avi" => CreateExpressVideoRequestRequestSourceContainer.Avi,
                "dv" => CreateExpressVideoRequestRequestSourceContainer.Dv,
                "flv" => CreateExpressVideoRequestRequestSourceContainer.Flv,
                "m1v" => CreateExpressVideoRequestRequestSourceContainer.M1v,
                "m2t" => CreateExpressVideoRequestRequestSourceContainer.M2t,
                "m2ts" => CreateExpressVideoRequestRequestSourceContainer.M2ts,
                "m2v" => CreateExpressVideoRequestRequestSourceContainer.M2v,
                "m4v" => CreateExpressVideoRequestRequestSourceContainer.M4v,
                "mkv" => CreateExpressVideoRequestRequestSourceContainer.Mkv,
                "mov" => CreateExpressVideoRequestRequestSourceContainer.Mov,
                "mp4" => CreateExpressVideoRequestRequestSourceContainer.Mp4,
                "mpeg" => CreateExpressVideoRequestRequestSourceContainer.Mpeg,
                "mpg" => CreateExpressVideoRequestRequestSourceContainer.Mpg,
                "mts" => CreateExpressVideoRequestRequestSourceContainer.Mts,
                "mxf" => CreateExpressVideoRequestRequestSourceContainer.Mxf,
                "ser" => CreateExpressVideoRequestRequestSourceContainer.Ser,
                "ts" => CreateExpressVideoRequestRequestSourceContainer.Ts,
                "vob" => CreateExpressVideoRequestRequestSourceContainer.Vob,
                "webm" => CreateExpressVideoRequestRequestSourceContainer.Webm,
                "wmv" => CreateExpressVideoRequestRequestSourceContainer.Wmv,
                _ => null,
            };
        }
    }
}