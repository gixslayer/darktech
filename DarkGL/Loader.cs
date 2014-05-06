using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DarkTech.DarkGL
{
    public class Loader
    {
        public delegate void LoadEvent(string function, string library);

        public static event LoadEvent Loading;
        public static event LoadEvent Loaded;
        public static event LoadEvent LoadingFailed;

        private static ILoadingProvider provider;

        /// <summary>
        /// Load the provider
        /// </summary>
        static Loader()
        {
            ChooseProvider();
        }

        static void ChooseProvider()
        {
            try
            {
                provider = new LoadingProviderWin();
            }
            catch (Exception e)
            {
                throw new Exception("Failed to load OpenGL library", e);
            }
        }

        /// <summary>
        /// Load class 
        /// </summary>
        public static void Load(Type classToLoad)
        {
            if (provider == null) ChooseProvider();
            if (classToLoad == null) return;
            FieldInfo[] fields = classToLoad.GetFields(BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                GLEntry[] entryDesc = (GLEntry[])field.GetCustomAttributes(typeof(GLEntry), false);
                if (entryDesc.Length == 0) continue;
                OnLoading(entryDesc[0].Name, classToLoad.ToString());
                IntPtr ptr = provider.GetProcAddress(classToLoad.Name, entryDesc[0].Name, entryDesc[0].Alias);
                if (ptr == IntPtr.Zero)
                {
                    OnLoadingFailed(entryDesc[0].Name, classToLoad.ToString());
                }
                else
                {
                    OnLoaded(entryDesc[0].Name, classToLoad.ToString());
                    try
                    {
                        field.SetValue(null, Marshal.GetDelegateForFunctionPointer(ptr, field.FieldType));
                    }
                    catch
                    {
                        OnLoadingFailed(entryDesc[0].Name, classToLoad.ToString());
                    }
                }
            }
        }

        static void OnLoading(string name, string library)
        {
            if (Loading != null)
            {
                Loading(name, library);
            }
        }

        static void OnLoaded(string name, string library)
        {
            if (Loaded != null)
            {
                Loaded(name, library);
            }
        }

        static void OnLoadingFailed(string name, string library)
        {
            if (LoadingFailed != null)
            {
                LoadingFailed(name, library);
            }
        }
    }
}
