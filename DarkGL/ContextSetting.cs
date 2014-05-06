namespace DarkTech.DarkGL
{
    /// <summary>
    /// Represents Context setting. 
    /// </summary>
    public class ContextSetting
    {
        /// <summary>
        /// Default context setting.
        /// </summary>
        public static readonly ContextSetting DEFAULT = new ContextSetting(24, 8, 24, 8, 0, 2, ContextProfile.Compatibility, ContextFlags.None, 0xff);

        /// <summary>
        /// Number of color bits.
        /// </summary>
        public byte ColorBits { get; set; }
        /// <summary>
        /// Number of alpha bits.
        /// </summary>
        public byte AlphaBits { get; set; }
        /// <summary>
        /// Number of depth bits.
        /// </summary>
        public byte DepthBits { get; set; }
        /// <summary>
        /// Number of stencil bits.
        /// </summary>
        public byte StencilBits { get; set; }
        /// <summary>
        /// Minimal requested OpenGL minor version.
        /// </summary>
        public byte MinorVersion { get; set; }
        /// <summary>
        /// Minimal requested OpenGL major version.
        /// </summary>
        public byte MajorVersion { get; set; }
        /// <summary>
        /// Context profile mask.
        /// </summary>
        public ContextProfile Profile { get; set; }
        /// <summary>
        /// Context flags.
        /// </summary>
        public ContextFlags Flags { get; set; }
        /// <summary>
        /// Number of samples. If set to 0xff, the context uses a maximal possible number of samples.
        /// </summary>
        public byte Multisample { get; set; }

        public ContextSetting() { }
        public ContextSetting(byte colorBits, byte alphaBits, byte depthBits, byte stencilBits, byte minorVersion, byte majorVersion, ContextProfile profile, ContextFlags flags, byte multisample)
        {
            this.ColorBits = colorBits;
            this.AlphaBits = alphaBits;
            this.DepthBits = depthBits;
            this.StencilBits = stencilBits;
            this.MinorVersion = minorVersion;
            this.MajorVersion = majorVersion;
            this.Profile = profile;
            this.Flags = flags;
            this.Multisample = multisample;
        }
    }
}
