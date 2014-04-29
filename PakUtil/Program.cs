using System;
using System.Collections.Generic;
using System.IO;

using DarkTech.Common.PAK;

namespace DarkTech.PakUtil
{
    static class Program
    {
        static string[] args;

        static void Main(string[] args)
        {
            Dictionary<string, Command> commands = new Dictionary<string, Command>();

            commands.Add("-c", new Command(new Action<string, string, string>(CreatePackage), "-if", "-of", "-c"));
            commands.Add("-e", new Command(new Action<string, string>(ExtractPackage), "-if", "-of"));
            commands.Add("-C", new Command(new Action<string, string>(CleanPackage), "-if", "-of"));
            commands.Add("-E", new Command(new Action<string, string, string>(ExtractEntry), "-if", "-e", "-of"));
            commands.Add("-a", new Command(new Action<string, string, string, string>(AddEntry), "-of", "-if", "-e", "-c"));
            commands.Add("-d", new Command(new Action<string, string>(DeleteEntry), "-if", "-e"));
            commands.Add("-l", new Command(new Action<string>(ListEntries), "-if"));
            commands.Add("-h", new Command(new Action(PrintHelp)));

            if (args == null || args.Length == 0) 
            {
                args = new string[] { "-h" };
            }

            Command command = null;

            if (commands.ContainsKey(args[0]))
            {
                command = commands[args[0]];
            }

            if (command == null || !command.Invoke(args))
            {
                PrintHelp();
            }

            Console.Read();
        }

        private static void CreatePackage(string inputFile, string outputFile, string compression)
        {
            FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
            PakEntryFlags flags = DetectCompression(compression);

            if (!inputFile.EndsWith("\\"))
            {
                inputFile += "\\";
            }

            foreach (string file in Directory.GetFiles(inputFile, "*", SearchOption.AllDirectories))
            {
                string entryName = file.Substring(inputFile.Length);
                FileStream inputStream = new FileStream(file, FileMode.Open, FileAccess.Read);

                PakEntry.Serialize(outputStream, inputStream, entryName, flags);

                inputStream.Dispose();
            }

            outputStream.Dispose();
        }

        private static void ExtractPackage(string inputFile, string outputFile)
        {
            byte[] buffer = new byte[4096];
            FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            PakFile pakFile = new PakFile(inputStream);

            foreach (PakEntry entry in pakFile.Entries)
            {
                string fullPath = Path.Combine(outputFile, entry.Name);
                DirectoryInfo targetDirectory = Directory.GetParent(fullPath);

                if (!targetDirectory.Exists)
                {
                    targetDirectory.Create();
                }

                Stream entryStream = pakFile.GetEntryStream(entry.Name);
                FileStream outputStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write);

                while (true)
                {
                    int bytesRead = entryStream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0) break;

                    outputStream.Write(buffer, 0, bytesRead);
                }

                outputStream.Dispose();
            }

            inputStream.Dispose();
        }

        private static void CleanPackage(string inputFile, string outputFile)
        {
            // TODO: Implement.
        }

        private static void ExtractEntry(string inputFile, string entryName, string outputFile)
        {
            FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            PakFile pakFile = new PakFile(inputStream);
            byte[] buffer = new byte[4096];

            if (!pakFile.HasEntry(entryName))
            {
                Console.WriteLine("!!!ERROR!!! ExtractEntry::Could not find entry {0}", entryName);

                Environment.Exit(1);
            }

            Stream entryStream = pakFile.GetEntryStream(entryName);
            FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);

            while (true)
            {
                int bytesRead = entryStream.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0) break;

                outputStream.Write(buffer, 0, bytesRead);
            }

            outputStream.Dispose();
            inputStream.Dispose();
        }

        private static void AddEntry(string outputFile, string inputFile, string entryName, string compression)
        {
            FileStream outputStream = new FileStream(outputFile, FileMode.Append, FileAccess.Write);
            FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            PakEntryFlags flags = DetectCompression(compression);

            PakEntry.Serialize(outputStream, inputStream, entryName, flags);

            inputStream.Dispose();
            outputStream.Dispose();
        }

        private static void DeleteEntry(string inputFile, string entryName)
        {
            // TODO: Implement.
        }

        private static void ListEntries(string inputFile)
        {
            FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            PakFile pakFile = new PakFile(inputStream);

            Console.WriteLine("Entries: {0}", pakFile.EntryCount);
            int i = 0;

            foreach (PakEntry entry in pakFile.Entries)
            {
                Console.WriteLine("{0}\t{1}\t({2}) @ {3} -> {4} bytes", i++, entry.Name, (byte)entry.Flags, entry.Offset, entry.Size);
            }

            inputStream.Dispose();
        }

        private static void PrintHelp()
        {
            // TODO: Implement.
        }

        private static PakEntryFlags DetectCompression(string compression)
        {
            switch (compression.ToLower())
            {
                case "gzip":
                    return PakEntryFlags.GZip;
                case "deflate":
                    return PakEntryFlags.Deflate;
                default:
                    return PakEntryFlags.None;
            }
        }

        class Command 
        {
            private readonly Delegate target;
            private readonly string[] namedArgs;

            public Command(Delegate target, params string[] namedArgs) 
            {
                if (target.Method.GetParameters().Length != namedArgs.Length)
                    throw new ArgumentException("Length must match delegate parameter length", "namedArgs");

                this.target = target;
                this.namedArgs = namedArgs;
            }

            public bool Invoke(string[] args)
            {
                int parameterCount = target.Method.GetParameters().Length;
                string[] invokeArgs = new string[parameterCount];

                for (int i = 0; i < invokeArgs.Length; i++)
                {
                    int index = FindParameterIndex(args, namedArgs[i]);

                    if (index == -1)
                    {
                        return false;
                    }

                    invokeArgs[i] = args[index];
                }

                try
                {
                    switch (parameterCount)
                    {
                        case 0:
                            target.DynamicInvoke();
                            return true;

                        case 1:
                            target.DynamicInvoke(invokeArgs[0]);
                            return true;

                        case 2:
                            target.DynamicInvoke(invokeArgs[0], invokeArgs[1]);
                            return true;

                        case 3:
                            target.DynamicInvoke(invokeArgs[0], invokeArgs[1], invokeArgs[2]);
                            return true;

                        case 4:
                            target.DynamicInvoke(invokeArgs[0], invokeArgs[1], invokeArgs[2], invokeArgs[3]);
                            return true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("!!!ERROR!!! Exception::{0}", e.Message);

                    Environment.Exit(1);
                }

                return false;
            }

            private static int FindParameterIndex(string[] args, string arg)
            {
                int result = -1;

                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i] == arg)
                    {
                        if (i + 1 < args.Length)
                        {
                            result = i + 1;
                        }

                        return result;
                    }
                }

                return result;
            }
        }
    }
}
