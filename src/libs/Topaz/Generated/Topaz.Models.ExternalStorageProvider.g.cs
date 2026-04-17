
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: s3
    /// </summary>
    public enum ExternalStorageProvider
    {
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalStorageProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalStorageProvider value)
        {
            return value switch
            {
                ExternalStorageProvider.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalStorageProvider? ToEnum(string value)
        {
            return value switch
            {
                "s3" => ExternalStorageProvider.S3,
                _ => null,
            };
        }
    }
}