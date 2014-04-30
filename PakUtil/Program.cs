using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using DarkTech.Common.IO;
using DarkTech.Common.PAK;

namespace DarkTech.PakUtil
{
    static class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Command> commands = new Dictionary<string, Command>();

            commands.Add("-c", new Command(new Action<string, string, string>(CreatePackage), "-if", "-of", "-c"));
            commands.Add("-e", new Command(new Action<string, string>(ExtractPackage), "-if", "-of"));
            commands.Add("-C", new Command(new Action<string, string>(CleanPackage), "-if", "-of"));
            commands.Add("-E", new Command(new Action<string, string, string>(ExtractEntry), "-if", "-e", "-of"));
            commands.Add("-a", new Command(new Action<string, string, string, string>(AddEntry), "-of", "-if", "-e", "-c"));
            commands.Add("-r", new Command(new Action<string, string>(RemoveEntry), "-if", "-e"));
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
        }

        private static void CreatePackage(string inputFile, string outputFile, string compression)
        {
            FileStream outputStream = OpenStream(outputFile, FileMode.Create, FileAccess.Write);
            PakEntryFlags flags = DetectCompression(compression);

            if (!inputFile.EndsWith("\\"))
            {
                inputFile += "\\";
            }

            foreach (string file in Directory.GetFiles(inputFile, "*", SearchOption.AllDirectories))
            {
                string entryName = file.Substring(inputFile.Length);
                FileStream inputStream = OpenStream(file, FileMode.Open, FileAccess.Read);

                PakEntry.Serialize(outputStream, inputStream, entryName, flags);

                inputStream.Dispose();
            }

            outputStream.Dispose();
        }

        private static void ExtractPackage(string inputFile, string outputFile)
        {
            byte[] buffer = new byte[4096];
            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.Read);
            PakFile pakFile = OpenPak(inputStream);

            foreach (PakEntry entry in pakFile.Entries)
            {
                string fullPath = Path.Combine(outputFile, entry.Name);
                DirectoryInfo targetDirectory = Directory.GetParent(fullPath);

                if (!targetDirectory.Exists)
                {
                    targetDirectory.Create();
                }

                Stream entryStream = pakFile.GetEntryStream(entry.Name);
                FileStream outputStream = OpenStream(fullPath, FileMode.Create, FileAccess.Write);

                while (true)
                {
                    int bytesRead = entryStream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0) break;

                    outputStream.Write(buffer, 0, bytesRead);
                }

                outputStream.Dispose();
            }

            pakFile.Close();
        }

        private static void CleanPackage(string inputFile, string outputFile)
        {
            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.Read);
            FileStream outputStream = OpenStream(outputFile, FileMode.Create, FileAccess.Write);
            List<PakEntry> entries = ReadEntries(inputStream);
            byte[] buffer = new byte[4096];

            foreach (PakEntry entry in entries)
            {
                // Skip removed entries.
                if (entry.HasFlag(PakEntryFlags.Removed))
                {
                    continue;
                }

                // Rewrite the entry header.
                byte[] nameBuffer = PakEntry.ENCODING.GetBytes(entry.Name);

                outputStream.WriteUShort((ushort)nameBuffer.Length);
                outputStream.Write(nameBuffer);
                outputStream.WriteByte((byte)entry.Flags);
                outputStream.WriteUInt((uint)entry.Size);

                // Copy the entry data to the output stream.
                long currentInputPosition = inputStream.Position;
                long bytesToCopy = entry.Size;

                inputStream.Position = entry.Offset;

                while (bytesToCopy > 0)
                {
                    int bytesToRead = bytesToCopy > buffer.Length ? buffer.Length : (int)bytesToCopy;

                    if (!inputStream.SaveRead(buffer, 0, bytesToRead))
                    {
                        Console.WriteLine("!!!ERROR!!! CleanPackage:Unexpected end of stream");

                        Environment.Exit(1);
                    }

                    outputStream.Write(buffer, 0, bytesToRead);

                    bytesToCopy -= bytesToRead;
                }
            }

            outputStream.Dispose();
            inputStream.Dispose();
        }

        private static void ExtractEntry(string inputFile, string entryName, string outputFile)
        {
            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.Read);
            PakFile pakFile = OpenPak(inputStream);
            byte[] buffer = new byte[4096];

            if (!pakFile.HasEntry(entryName))
            {
                Console.WriteLine("!!!ERROR!!! ExtractEntry::Could not find entry {0}", entryName);

                Environment.Exit(1);
            }

            Stream entryStream = pakFile.GetEntryStream(entryName);
            FileStream outputStream = OpenStream(outputFile, FileMode.Create, FileAccess.Write);

            while (true)
            {
                int bytesRead = entryStream.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0) break;

                outputStream.Write(buffer, 0, bytesRead);
            }

            outputStream.Dispose();
            pakFile.Close();
        }

        private static void AddEntry(string outputFile, string inputFile, string entryName, string compression)
        {
            FileStream outputStream = OpenStream(outputFile, FileMode.Append, FileAccess.Write);
            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.Read);
            PakEntryFlags flags = DetectCompression(compression);

            PakEntry.Serialize(outputStream, inputStream, entryName, flags);

            inputStream.Dispose();
            outputStream.Dispose();
        }

        private static void RemoveEntry(string inputFile, string entryName)
        {
            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.ReadWrite);
            PakFile pakFile = OpenPak(inputStream);

            if (!pakFile.HasEntry(entryName))
            {
                Console.WriteLine("!!!ERROR!!! RemoveEntry:Could not find entry {0}", entryName);

                Environment.Exit(1);
            }

            PakEntry entry = pakFile[entryName];
            entry.SetFlag(PakEntryFlags.Removed);

            // Set the stream position to the flag byte.
            inputStream.Position = entry.Offset - 5;

            // Write the new flag byte.
            inputStream.WriteByte((byte)entry.Flags);

            pakFile.Close();
        }

        private static void ListEntries(string inputFile)
        {
            // Format:
            // Package: {inputFile}
            // Total entries: {entries.Count]
            //
            // Index | Name | Flags | Offset | Size
            // ------|------|-------|-------|------

            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.Read);
            List<PakEntry> entries = ReadEntries(inputStream);
            List<List<string>> columnData = new List<List<string>>();
            string[] columnHeaders = { "Index", "Name", "Flags", "Offset", "Size" };
            int columnCount = columnHeaders.Length;
            int[] columnLength = new int[columnCount];
            
            // Build the column data.
            int entryIndex = 0;

            foreach (PakEntry entry in entries)
            {
                List<string> row = new List<string>();

                row.Add(entryIndex.ToString());
                row.Add(entry.Name);
                row.Add(entry.Flags.ToString());
                row.Add(entry.Offset.ToString("X2"));
                row.Add(entry.Size.ToString("X2"));

                entryIndex++;

                columnData.Add(row);
            }

            // Find longest field for each column.
            for (int i = 0; i < columnCount; i++) 
            {
                int length = columnHeaders[i].Length;

                foreach (List<string> row in columnData)
                {
                    int fieldLength = row[i].Length;

                    if (fieldLength > length)
                    {
                        length = fieldLength;
                    }
                }

                columnLength[i] = length;
            }

            // Write the initial information.
            Console.WriteLine("Package: {0}", inputFile);
            Console.WriteLine("Total entries: {0}", entries.Count);
            Console.WriteLine();

            // Write column headers.
            for (int i = 0; i < columnCount; i++)
            {
                Console.Write(PadString(columnHeaders[i], ' ', columnLength[i]));

                if (i + 1 != columnCount)
                {
                    Console.Write(" | ");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            // Write row separator.
            for (int i = 0; i < columnCount; i++)
            {
                Console.Write(PadString(string.Empty, '-', columnLength[i]));

                if (i + 1 != columnCount)
                {
                    Console.Write("-|-");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            // Write rows.
            foreach (List<string> row in columnData)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    Console.Write(PadString(row[i], ' ', columnLength[i]));

                    if (i + 1 != columnCount)
                    {
                        Console.Write(" | ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

            inputStream.Dispose();
        }

        private static void PrintHelp()
        {
            Console.WriteLine("-c   Create a new package from a source directory");
            Console.WriteLine("     -if {path}  The path to the source directory");
            Console.WriteLine("     -of {path}  The destination path for the package");
            Console.WriteLine("     -c  {comp}  The compression to use (valid options: none/gzip/deflate)");
            Console.WriteLine("-e   Extract an entire package to a directory");
            Console.WriteLine("     -if {path}  The path to the package");
            Console.WriteLine("     -of {path}  The destination directory for the entries");
            Console.WriteLine("-C   Clean a package by removing removed entries");
            Console.WriteLine("     -if {path}  The path to the source package");
            Console.WriteLine("     -of {path}  The destination path for the cleaned package");
            Console.WriteLine("-E   Extract a single entry from a package");
            Console.WriteLine("     -if {path}  The path to the package");
            Console.WriteLine("     -of {path}  The destination path for the extracted entry");
            Console.WriteLine("     -e  {name}  The name of the entry");
            Console.WriteLine("-a   Add a file to a package (will append to an existing package)");
            Console.WriteLine("     -if {path}  The path to the file to add");
            Console.WriteLine("     -of {path}  The destination path for the package");
            Console.WriteLine("     -e  {name}  The name of the entry");
            Console.WriteLine("     -c  {comp}  The compression to use (valid options: none/gzip/deflate)");
            Console.WriteLine("-r   Remove an entry from a package");
            Console.WriteLine("     -if {path}  The path to the package");
            Console.WriteLine("     -e  {name}  The name of the entry");
            Console.WriteLine("-l   List all entries in a package (including entries marked as removed)");
            Console.WriteLine("     -if {path}  The path to the package");
            Console.WriteLine("-h   Display this help message");
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

        private static FileStream OpenStream(string path, FileMode mode, FileAccess access)
        {
            if (mode == FileMode.CreateNew && File.Exists(path))
            {
                Console.WriteLine("!!!ERROR!!! OpenStream:File {0} already exists", path);

                Environment.Exit(1);
            }

            if (mode == FileMode.Open && !File.Exists(path))
            {
                Console.WriteLine("!!!ERROR!!! OpenStream:File {0} could not be found", path);

                Environment.Exit(1);
            }

            try
            {
                return new FileStream(path, mode, access);
            }
            catch (Exception e)
            {
                Console.WriteLine("!!!ERROR!!! OpenStream:{0}", e.Message);

                Environment.Exit(1);
            }

            // Should never be reached.
            return null;
        }

        private static PakFile OpenPak(FileStream inputStream)
        {
            try
            {
                return new PakFile(inputStream);
            }
            catch (PakException e)
            {
                Console.WriteLine("!!!ERROR!!!: OpenPak:{0}", e.Message);

                Environment.Exit(1);
            }

            // Should never be reached.
            return null;
        }

        private static List<PakEntry> ReadEntries(FileStream inputStream)
        {
            try
            {
                return PakFile.GetEntries(inputStream);
            }
            catch (PakException e)
            {
                Console.WriteLine("!!!ERROR!!! PakFile.GetEntries:{0}", e.Message);

                Environment.Exit(1);
            }

            // Should never be reached.
            return null;
        }

        private static string PadString(string sourceString, char paddingChar, int targetLength)
        {
            if (sourceString.Length >= targetLength)
            {
                return sourceString;
            }

            StringBuilder stringBuilder = new StringBuilder(sourceString, targetLength);

            for (int i = 0; i < targetLength - sourceString.Length; i++)
            {
                stringBuilder.Append(paddingChar);
            }

            return stringBuilder.ToString();
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
