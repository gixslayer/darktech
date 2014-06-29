namespace DarkTech.Engine
{
    /// <summary>
    /// The network model of the engine.
    /// </summary>
    public enum NetModel
    {
        /// <summary>
        /// Client only.
        /// </summary>
        ClientOnly,
        /// <summary>
        /// Server only.
        /// </summary>
        ServerOnly,
        /// <summary>
        /// Client with a local server.
        /// </summary>
        Local
    }
}
