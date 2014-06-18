using System;
using System.Collections.Generic;
using System.Reflection;

using DarkTech.Engine.FileSystem;

namespace DarkTech.Engine.Utils
{
    internal static class AssemblyUtils
    {
        private static Assembly LoadAssembly(string path)
        {
            if (!Engine.FileSystem.FileExists(path))
            {
                Engine.Errorf("Could not find assembly {0}", path);

                return null;
            }

            File file;

            if (!Engine.FileSystem.OpenFile(path, FileMode.Open, FileAccess.Read, out file))
                return null;

            byte[] assemblyData = new byte[file.Size];
            file.Read(assemblyData, 0, assemblyData.Length);

            file.Dispose();

            try
            {
                return Assembly.Load(assemblyData);
            }
            catch (BadImageFormatException)
            {
                Engine.Errorf("Failed to load assembly {0} -> Bad image format", path);

                return null;
            }
        }

        public static T LoadType<T>(string path)
        {
            T result;

            LoadType<T>(path, out result);

            return result;
        }

        public static bool LoadType<T>(string path, out T result)
        {
            result = default(T);
            Type target = typeof(T);
            Assembly assembly = LoadAssembly(path);

            // Make sure the assembly was loaded correctly.
            if (assembly == null)
                return false;

            foreach (Type type in assembly.ExportedTypes)
            {
                if (type.IsAbstract || !type.IsClass)
                    continue;
                if (type.ContainsGenericParameters)
                    continue;
                if (!target.IsAssignableFrom(type))
                    continue;

                try
                {
                    result = (T)Activator.CreateInstance(type);

                    return true;
                }
                catch (Exception e)
                {
                    Engine.Errorf("Failed to create instance of type {0} in assembly {1} -> {2}", target.Name, path, e.Message);
                }
            }

            Engine.Errorf("Failed to create instance of type {0} in assembly {1} -> No suitable type found", target.Name, path);

            return false;
        }

        public static List<T> LoadTypes<T>(string path)
        {
            List<T> result = new List<T>();
            Type target = typeof(T);
            Assembly assembly = LoadAssembly(path);

            if (assembly == null)
                return result;

            foreach (Type type in assembly.ExportedTypes)
            {
                if (type.IsAbstract || !type.IsClass)
                    continue;
                if (type.ContainsGenericParameters)
                    continue;
                if (!target.IsAssignableFrom(type))
                    continue;

                try
                {
                    T instance = (T)Activator.CreateInstance(type);

                    result.Add(instance);
                }
                catch (Exception e)
                {
                    Engine.Errorf("Failed to create instance of type {0} in assembly {1} -> {2}", target.Name, path, e.Message);
                }
            }

            return result;
        }

        public static List<object> LoadGenericTypes(Type genericType, string path)
        {
            List<object> result = new List<object>();
            Assembly assembly = LoadAssembly(path);

            if (assembly == null)
                return result;

            foreach (Type type in assembly.ExportedTypes)
            {
                if (type.IsAbstract || !type.IsClass)
                    continue;
                if (type.ContainsGenericParameters)
                    continue;
                if (!TypeContainsGenericType(type, genericType))
                    continue;
                //if (!type.BaseType.GUID.Equals(genericType.GUID))
                    //continue;

                try
                {
                    result.Add(Activator.CreateInstance(type));
                }
                catch (Exception e)
                {
                    Engine.Error(e.Message);
                }

            }

            return result;
        }

        public static List<Type[]> GetGenericTypes(List<object> objects, Type genericType)
        {
            List<Type[]> result = new List<Type[]>();

            foreach (object obj in objects)
            {
                Type type = obj.GetType();

                for (Type baseType = type.BaseType; baseType != null; baseType = baseType.BaseType)
                {
                    if (!baseType.IsGenericType)
                        continue;

                    if (baseType.GUID.Equals(genericType.GUID))
                    {
                        result.Add(baseType.GenericTypeArguments);

                        break;
                    }
                }
            }

            return result;
        }

        private static bool TypeContainsGenericType(Type type, Type genericType)
        {
            for (Type baseType = type.BaseType; baseType != null; baseType = baseType.BaseType)
            {
                if (!baseType.IsGenericType)
                    continue;

                if (baseType.GUID.Equals(genericType.GUID))
                    return true;
            }

            return false;
        }
    }
}
