using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// ILoadingProvider implementation for Windows
    /// </summary>
    internal class LoadingProviderWin : ILoadingProvider
    {
        public const string GLLibName = "OPENGL32.DLL";

        /// <summary>
        /// OpenGL library handle
        /// </summary>
        private IntPtr GLLib;

        /// <summary>
        /// Loads OpenGL library and test the functionality
        /// </summary>
        public LoadingProviderWin()
        {
            GLLib = Windows.LoadLibrary(GLLibName);

            // Test the presence of OpenGL library
            if (GLLib == IntPtr.Zero)
                throw new DllNotFoundException("The OpenGL library cannot be found!");

            // Test the OpenGL library functionality - try to get address of glClear function          
            IntPtr address = wgl.GetProcAddress("glClear");

            if (address == null)
            {
                throw new DllNotFoundException("The OpenGL library seems to be invalid!");
            }
        }

        /// <summary>
        /// Free the OpenGL library
        /// </summary>
        ~LoadingProviderWin()
        {
            Windows.FreeLibrary(GLLib);
        }

        public IntPtr GetProcAddress(string library, string entry, string alias)
        {
            // try load from the DLL
            IntPtr ptr = Windows.GetProcAddress(GLLib, library + entry);

            // if no success, load it as an extension
            if (ptr == IntPtr.Zero)
            { 
                ptr = wgl.GetProcAddress(library + entry); 
            }
                
           
            if (ptr == IntPtr.Zero)
            {
                if (alias != null)
                {
                    string[] aliases = alias.Trim().Split(new char[] { ' ' });

                    foreach (string name in aliases)
                    {
                        ptr = wgl.GetProcAddress(library + name);

                        if (ptr != IntPtr.Zero) 
                            break;
                    }
                }
            }

            return ptr;
        }
    }
}
