using System;
using System.IO;
using System.Text;

using DarkTech.Common.Containers;
using DarkTech.Common.IO;
using DarkTech.Common.PAK;

namespace DarkTech.PakUtil
{
    static class Program
    {
        static void Main(string[] args)
        {
            IMap<string, Command> commands = new HashMap<string, Command>();

            commands.Add("-c", new Command(new Action<string, string>(CreatePackage), "-if", "-of"));
            commands.Add("-e", new Command(new Action<string, string>(ExtractPackage), "-if", "-of"));
            commands.Add("-E", new Command(new Action<string, string, string>(ExtractEntry), "-if", "-e", "-of"));
            commands.Add("-a", new Command(new Action<string, string, string>(AddEntry), "-of", "-if", "-e"));
            commands.Add("-l", new Command(new Action<string>(ListEntries), "-if"));
            commands.Add("-h", new Command(new Action(PrintHelp)));

            if (args == null || args.Length == 0) 
            {
                args = new string[] { "-h" };
            }

            Command command = null;

            if (commands.Contains(args[0]))
            {
                command = commands[args[0]];
            }

            if (command == null || !command.Invoke(args))
            {
                PrintHelp();
            }
        }

        private static void CreatePackage(string inputFile, string outputFile)
        {
            FileStream outputStream = OpenStream(outputFile, FileMode.Create, FileAccess.Write);
            DataStream dataStream = new DataStream(outputStream);

            if (!inputFile.EndsWith("\\"))
            {
                inputFile += "\\";
            }

            foreach (string file in Directory.GetFiles(inputFile, "*", SearchOption.AllDirectories))
            {
                string entryName = file.Substring(inputFile.Length);
                FileStream inputStream = OpenStream(file, FileMode.Open, FileAccess.Read);

                PakEntry.Serialize(dataStream, inputStream, entryName);

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

        private static void AddEntry(string outputFile, string inputFile, string entryName)
        {
            FileStream outputStream = OpenStream(outputFile, FileMode.Append, FileAccess.Write);
            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.Read);
            DataStream dataStream = new DataStream(outputStream);

            PakEntry.Serialize(dataStream, inputStream, entryName);

            inputStream.Dispose();
            outputStream.Dispose();
        }

        private static void ListEntries(string inputFile)
        {
            // Format:
            // Package: {inputFile}
            // Total entries: {entries.Count]
            //
            // Index | Name | Offset | Size
            // ------|------|--------|------

            FileStream inputStream = OpenStream(inputFile, FileMode.Open, FileAccess.Read);
            IList<PakEntry> entries = ReadEntries(inputStream);
            IList<IList<string>> columnData = new ArrayList<IList<string>>(entries.Count);
            string[] columnHeaders = { "Index", "Name", "Offset", "Size" };
            int columnCount = columnHeaders.Length;
            int[] columnLength = new int[columnCount];
            
            // Build the column data.
            int entryIndex = 0;

            foreach (PakEntry entry in entries)
            {
                IList<string> row = new ArrayList<string>(4);

                row.Add(entryIndex.ToString());
                row.Add(entry.Name);
                row.Add(entry.Offset.ToString("X2"));
                row.Add(entry.Size.ToString("X2"));

                entryIndex++;

                columnData.Add(row);
            }

            // Find longest field for each column.
            for (int i = 0; i < columnCount; i++) 
            {
                int length = columnHeaders[i].Length;

                foreach (IList<string> row in columnData)
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
            foreach (IList<string> row in columnData)
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
            Console.WriteLine("-r   Remove an entry from a package");
            Console.WriteLine("     -if {path}  The path to the package");
            Console.WriteLine("     -e  {name}  The name of the entry");
            Console.WriteLine("-l   List all entries in a package (including entries marked as removed)");
            Console.WriteLine("     -if {path}  The path to the package");
            Console.WriteLine("-h   Display this help message");
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

        private static IList<PakEntry> ReadEntries(FileStream inputStream)
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
