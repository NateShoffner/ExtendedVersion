using System;

namespace ExtendedVersion
{
    /// <summary>
    ///     Provides enumerated values to use to set version string formatting options.
    /// </summary>
    [Flags]
    public enum ExtendedVersionFormatFlags
    {
        /// <summary>
        ///     Specifies that no options are set.
        /// </summary>
        None = 0x0,

        /// <summary>
        ///     Specifies that the build version should be appended to the version string.
        /// </summary>
        Build = 0x1,

        /// <summary>
        ///     Specifies that the build version should be appended in a human-friendly format to the version string. (Ex: 1.0.2
        ///     (Build 12))
        /// </summary>
        BuildString = 0x2,

        /// <summary>
        ///     Specifies that the commit id should be appended to the version string using the full format. (Ex: 1.0.2
        ///     57bf835dd5a21e031df7d8940c9483125b1575e0)
        /// </summary>
        CommitFull = 0x4,

        /// <summary>
        ///     Specifies that the commit id should be appended to the version string using the short format. (Ex: 1.0.2 57bf835)
        /// </summary>
        CommitShort = 0x8,

        /// <summary>
        ///     Specifies that the version string should be truncated of trailing zeros.
        /// </summary>
        Truncated = 0x10
    }
}