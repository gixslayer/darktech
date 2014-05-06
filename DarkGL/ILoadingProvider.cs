using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Interface to provide a way to load GL entries
    /// </summary>
    internal interface ILoadingProvider
    {
        IntPtr GetProcAddress(string library, string entry, string alias);
    }
}
