using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DarkTech.DarkGL
{
    public static class Loader
    {
        public delegate void LoadEvent(string function, string library);

        public static event LoadEvent Loading = delegate { };
        public static event LoadEvent Loaded = delegate { };
        public static event LoadEvent LoadingFailed = delegate { };

        private static readonly ILoadingProvider provider;

        static Loader()
        {
            // Assign the static provider member based on the current platform.
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    provider = new LoadingProviderWin();
                    break;

                default:
                    throw new PlatformNotSupportedException();
            }
        }

        public static void Load<T>()
        {
            // Provider should never be null as the static constructor will assign an instance or throw an exception.
            // If the static constructor threw an exception this method should never be called.
            //if (provider == null) ChooseProvider();

            // Grab all declared fields in the target type and enumerate them.
            Type glEntryType = typeof(GLEntry);
            Type targetType = typeof(T);
            string targetName = targetType.Name;
            FieldInfo[] fields = targetType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

            foreach (FieldInfo field in fields)
            {
                // Grab all the GLEntry attributes declared in the field.
                GLEntry[] entryAttributes = (GLEntry[])field.GetCustomAttributes(glEntryType, false);

                // If no GLEntry attributes were defined then skip to the next field.
                if (entryAttributes.Length == 0)
                {
                    continue;
                }

                // Notify all Loading event listeners we're about to load an entry.
                Loading(entryAttributes[0].Name, targetName);

                // Try to grab the function pointer from the provider.
                IntPtr ptrFunc = provider.GetProcAddress(targetName, entryAttributes[0].Name, entryAttributes[0].Alias);

                if (ptrFunc == IntPtr.Zero)
                {
                    // If the provider failed to grab the function pointer then notify all LoadingFailed event listeners
                    // that the entry failed to load.
                    LoadingFailed(entryAttributes[0].Name, targetName);
                }
                else
                {
                    try
                    {
                        // Function pointer grabbed, try to set the field's delegate to that pointer.
                        field.SetValue(null, Marshal.GetDelegateForFunctionPointer(ptrFunc, field.FieldType));

                        // Notify all Loaded event listeners the entry loaded successfully.
                       Loaded(entryAttributes[0].Name, targetName);
                    }
                    catch
                    {
                        // Function pointer grabbed successfully, but failed to set the field's delegate to that pointer.
                        // Notify all LoadingFailed event listeners the entry failed to load.
                        LoadingFailed(entryAttributes[0].Name, targetName);
                    }
                }
            }
        }
    }
}
