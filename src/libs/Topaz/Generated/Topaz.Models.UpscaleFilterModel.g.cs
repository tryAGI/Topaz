
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Short code name for the AI model.<br/>
    /// Newer models may be accepted before they appear in this list — call `GET /video/status` for the authoritative set of currently supported models.<br/>
    /// Example: prob-4
    /// </summary>
    public enum UpscaleFilterModel
    {
        /// <summary>
        ///
        /// </summary>
        Aaa10,
        /// <summary>
        ///
        /// </summary>
        Aaa9,
        /// <summary>
        ///
        /// </summary>
        Ahq12,
        /// <summary>
        ///
        /// </summary>
        Alq13,
        /// <summary>
        ///
        /// </summary>
        Alqs2,
        /// <summary>
        ///
        /// </summary>
        Amq13,
        /// <summary>
        ///
        /// </summary>
        Amqs2,
        /// <summary>
        ///
        /// </summary>
        Ddv3,
        /// <summary>
        ///
        /// </summary>
        Dtd4,
        /// <summary>
        ///
        /// </summary>
        Dtds2,
        /// <summary>
        ///
        /// </summary>
        Dtv4,
        /// <summary>
        ///
        /// </summary>
        Dtvs2,
        /// <summary>
        ///
        /// </summary>
        Gcg5,
        /// <summary>
        ///
        /// </summary>
        Ghq5,
        /// <summary>
        ///
        /// </summary>
        Hyp1,
        /// <summary>
        ///
        /// </summary>
        Iris2,
        /// <summary>
        ///
        /// </summary>
        Iris3,
        /// <summary>
        ///
        /// </summary>
        Nxf1,
        /// <summary>
        ///
        /// </summary>
        Nxl1,
        /// <summary>
        ///
        /// </summary>
        Nyx3,
        /// <summary>
        ///
        /// </summary>
        Pnat1,
        /// <summary>
        ///
        /// </summary>
        Prob4,
        /// <summary>
        ///
        /// </summary>
        Rhea1,
        /// <summary>
        ///
        /// </summary>
        Stab1,
        /// <summary>
        ///
        /// </summary>
        Thd3,
        /// <summary>
        ///
        /// </summary>
        Thf4,
        /// <summary>
        ///
        /// </summary>
        Thm2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleFilterModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFilterModel value)
        {
            return value switch
            {
                UpscaleFilterModel.Aaa10 => "aaa-10",
                UpscaleFilterModel.Aaa9 => "aaa-9",
                UpscaleFilterModel.Ahq12 => "ahq-12",
                UpscaleFilterModel.Alq13 => "alq-13",
                UpscaleFilterModel.Alqs2 => "alqs-2",
                UpscaleFilterModel.Amq13 => "amq-13",
                UpscaleFilterModel.Amqs2 => "amqs-2",
                UpscaleFilterModel.Ddv3 => "ddv-3",
                UpscaleFilterModel.Dtd4 => "dtd-4",
                UpscaleFilterModel.Dtds2 => "dtds-2",
                UpscaleFilterModel.Dtv4 => "dtv-4",
                UpscaleFilterModel.Dtvs2 => "dtvs-2",
                UpscaleFilterModel.Gcg5 => "gcg-5",
                UpscaleFilterModel.Ghq5 => "ghq-5",
                UpscaleFilterModel.Hyp1 => "hyp-1",
                UpscaleFilterModel.Iris2 => "iris-2",
                UpscaleFilterModel.Iris3 => "iris-3",
                UpscaleFilterModel.Nxf1 => "nxf-1",
                UpscaleFilterModel.Nxl1 => "nxl-1",
                UpscaleFilterModel.Nyx3 => "nyx-3",
                UpscaleFilterModel.Pnat1 => "pnat-1",
                UpscaleFilterModel.Prob4 => "prob-4",
                UpscaleFilterModel.Rhea1 => "rhea-1",
                UpscaleFilterModel.Stab1 => "stab-1",
                UpscaleFilterModel.Thd3 => "thd-3",
                UpscaleFilterModel.Thf4 => "thf-4",
                UpscaleFilterModel.Thm2 => "thm-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFilterModel? ToEnum(string value)
        {
            return value switch
            {
                "aaa-10" => UpscaleFilterModel.Aaa10,
                "aaa-9" => UpscaleFilterModel.Aaa9,
                "ahq-12" => UpscaleFilterModel.Ahq12,
                "alq-13" => UpscaleFilterModel.Alq13,
                "alqs-2" => UpscaleFilterModel.Alqs2,
                "amq-13" => UpscaleFilterModel.Amq13,
                "amqs-2" => UpscaleFilterModel.Amqs2,
                "ddv-3" => UpscaleFilterModel.Ddv3,
                "dtd-4" => UpscaleFilterModel.Dtd4,
                "dtds-2" => UpscaleFilterModel.Dtds2,
                "dtv-4" => UpscaleFilterModel.Dtv4,
                "dtvs-2" => UpscaleFilterModel.Dtvs2,
                "gcg-5" => UpscaleFilterModel.Gcg5,
                "ghq-5" => UpscaleFilterModel.Ghq5,
                "hyp-1" => UpscaleFilterModel.Hyp1,
                "iris-2" => UpscaleFilterModel.Iris2,
                "iris-3" => UpscaleFilterModel.Iris3,
                "nxf-1" => UpscaleFilterModel.Nxf1,
                "nxl-1" => UpscaleFilterModel.Nxl1,
                "nyx-3" => UpscaleFilterModel.Nyx3,
                "pnat-1" => UpscaleFilterModel.Pnat1,
                "prob-4" => UpscaleFilterModel.Prob4,
                "rhea-1" => UpscaleFilterModel.Rhea1,
                "stab-1" => UpscaleFilterModel.Stab1,
                "thd-3" => UpscaleFilterModel.Thd3,
                "thf-4" => UpscaleFilterModel.Thf4,
                "thm-2" => UpscaleFilterModel.Thm2,
                _ => null,
            };
        }
    }
}