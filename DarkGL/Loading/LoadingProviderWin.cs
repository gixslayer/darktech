using System;

using DarkTech.NativeWin32.Kernel32;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// ILoadingProvider implementation for Windows.
    /// </summary>
    internal sealed class LoadingProviderWin : ILoadingProvider
    {
        public const string OPENGL32DLL = "OPENGL32.DLL";

        private readonly IntPtr hOpenGL;

        public LoadingProviderWin()
        {
            // Attempt to load the openGL library.
            hOpenGL = Kernel32.LoadLibrary(OPENGL32DLL);

            // Validate the library was loaded successfully.
            if (hOpenGL == IntPtr.Zero)
            {
                // Library failed to load. Grab the last error code/message and throw an exception.
                throw new GLException(string.Format("Failed to load OpenGL library: {0} (error code: {1})", Kernel32.GetLastErrorMsg(), Kernel32.GetLastError()));
            }
        }

        ~LoadingProviderWin()
        {
            // Free the handle to the OpenGL library if it was loaded successfully.
            if (hOpenGL != IntPtr.Zero)
            {
                Kernel32.FreeLibrary(hOpenGL);
            }
        }

        public IntPtr GetProcAddress(string library, string entry, string alias)
        {
            // Try to grab the function pointer from the OpenGL library.
            IntPtr ptrFunc = Kernel32.GetProcAddress(hOpenGL, library + entry);

            // If that failed then try to load it as an extension instead.
            if (ptrFunc == IntPtr.Zero)
            { 
                ptrFunc = wgl.GetProcAddress(library + entry); 
            }

            // If we still failed to grab a function pointer then check if one or multiple aliases were defined.
            if (ptrFunc == IntPtr.Zero && !string.IsNullOrWhiteSpace(alias))
            {
                // The alias string is split by string, EG: "Alias1 Alias2 ... AliasN"
                string[] aliases = alias.Trim().Split(' ');

                // Enumerate all aliases in the alias string.
                foreach (string name in aliases)
                {
                    // Try to grab a function pointer to the alias.
                    ptrFunc = wgl.GetProcAddress(library + name);

                    // If a valid function pointer was grabbed to the alias then use that as the function pointer for the actual entry.
                    if (ptrFunc != IntPtr.Zero)
                    {
                        return ptrFunc;
                    }
                }
            }

            return ptrFunc;
        }
    }
}
