using System;
using System.Collections.Generic;
using System.IO;

using DarkTech.Common.PAK;

namespace DarkTech.PakUtil
{
    static class Program
    {
        private static string[] args;
        private delegate void CmdArgHandler();

        static void Main()
        {
            // Build the command line handling system.
            Dictionary<string, CmdArg> commandArgs = new Dictionary<string, CmdArg>();
            //commandArgs.Add("-cli", new CmdArg(0, StartCLI));
            commandArgs.Add("-c", new CmdArg(3, Create));
            commandArgs.Add("-e", new CmdArg(2, ExtractAll));
            //commandArgs.Add("-E", new CmdArg(3, Extract));
            //commandArgs.Add("-a", new CmdArg(3, Add));
            //commandArgs.Add("-r", new CmdArg(2, Remove));
            //commandArgs.Add("-R", new CmdArg(3, Rename));
            commandArgs.Add("-d", new CmdArg(1, Dump));
            commandArgs.Add("-h", new CmdArg(0, PrintHelp));

            // Functionality:
            // Both GUI and CLI
            // Create new pak files from a source directory.
            // Add file(s) to an existing pak file.
            // Remove file(s) from an existing pak file.
            // Rename file(s) in an existing pak file.
            // Extract file(s) from an existing pak file.
            // Dump info from an existing pak file.

            // Command line args:
            // [] means that the arguments can be repetitive and should be treated as a list/array.
            // -cli                     Starts the interactive cli.
            // -c source dest           Creates a new pak file and adds all files in the source directory then saves it to dest.
            // -e source dest           Extract the all entries in the source pak file to the dest directory.
            // -E source [entry dest]   Extract the entry in the source pak file to the dest path.
            // -a source [entry path]   Adds the file at path to the source pak file under the name entry.
            // -r source [entry]        Removes the entry from the source pak file.
            // -R source [entry name]   Renames the entry to name in the source pak file.
            // -d source                Dumps information about the source pak file to stdout.
            // -h                       Print help.
            // source                   Opens the source pak file in GUI mode.

            // First command line argument is the program name.
            string[] commandLineArguments = Environment.GetCommandLineArgs();

            // If there is more than one argument, additional command line args were passed in that need to be handled.
            if (commandLineArguments.Length > 1)
            {
                // Copy the arguments following the program name to a new static array.
                args = new string[commandLineArguments.Length - 1];
                
                //commandLineArguments.CopyTo(args, 1);

                for (int i = 0; i < args.Length; i++)
                {
                    args[i] = commandLineArguments[i + 1];
                }

                    if (commandArgs.ContainsKey(args[0]))
                    {
                        // Check if the argument count is correct.
                        if (args.Length - 1 < commandArgs[args[0]].ArgCount)
                        {
                            PrintHelp();
                        }
                        else
                        {
                            // Invoke the handler.
                            commandArgs[args[0]].Handler.Invoke();
                        }

                        // Exit the application before the GUI is launched.
                        Environment.Exit(0);
                    }
                    else
                    {
                        // The argument is considered to be a location to a valid pak file. 
                        // Load the pak file to verify this and if loaded correctly set a static variable in the GUI so it knows it has to display that pak file.
                        PakFile pakFile;

                        if (OpenPak(args[0], out pakFile))
                        {
                            // TODO: Set static variable in GUI.
                        }
                    }
            }
        }

        private static void StartCLI()
        {

        }

        private static void Create()
        {
            FileStream outStream = new FileStream(args[1], FileMode.Create, FileAccess.Write);
            PakEntryFlags flags;

            if (!args[2].EndsWith("\\"))
            {
                args[2] += "\\";
            }

            if (args[3] == "gzip")
            {
                flags = PakEntryFlags.GZip;
            }
            else if (args[3] == "deflate")
            {
                flags = PakEntryFlags.Deflate;
            }
            else
            {
                flags = PakEntryFlags.None;
            }

            foreach (string file in Directory.GetFiles(args[2], "*", SearchOption.AllDirectories))
            {
                string entryName = file.Substring(args[2].Length);

                FileStream source = new FileStream(file, FileMode.Open, FileAccess.Read);

                PakEntry.Serialize(outStream, source, entryName, flags);

                source.Close();
                source.Dispose();
            }

            outStream.Close();
            outStream.Dispose();
        }

        private static void ExtractAll()
        {
            FileStream pakStream = new FileStream(args[1], FileMode.Open, FileAccess.Read);
            PakFile pak = new PakFile(pakStream);

            foreach (PakEntry entry in pak.Entries)
            {
                string fullPath = Path.Combine(args[2], entry.Name);

                DirectoryInfo directory = Directory.GetParent(fullPath);

                if (!directory.Exists)
                {
                    directory.Create();
                }

                Stream entryStream = pak.GetEntryStream(entry.Name);

                FileStream dest = new FileStream(fullPath, FileMode.Create, FileAccess.Write);

               byte[] buffer = new byte[4096];

                while (true)
                {
                    int bytesRead = entryStream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0) break;

                    dest.Write(buffer, 0, bytesRead);
                }

                //pak.Extract(entry, dest);

                dest.Close();
                dest.Dispose();
            }

            pak.Close();
        }

        private static void Extract()
        {

        }

        private static void Add()
        {

        }

        private static void Rename()
        {

        }

        private static void Remove()
        {

        }

        private static void Dump()
        {
            PakFile pakFile;

            if (!OpenPak(args[1], out pakFile))
            {
                return;
            }

            Console.WriteLine("Dumping information for pak file {0}", args[1]);
            Console.WriteLine("Entries: {0}", pakFile.EntryCount);
            int i = 0;

            foreach (PakEntry entry in pakFile.Entries)
            {
                Console.WriteLine("{0}\t{1}\t({2}) @ {3} -> {4} bytes", i++, entry.Name, (byte)entry.Flags, entry.Offset, entry.Size);
            }

            pakFile.Close();
        }

        private static void PrintHelp()
        {

        }

        private static bool OpenStream(string path, FileMode mode, FileAccess access, out FileStream stream)
        {
            stream = null;

            if ((mode == FileMode.Open || mode == FileMode.Truncate) && !File.Exists(path))
            {
                Console.Error.WriteLine("Could not find file {0}", path);

                return false;
            }

            if (mode == FileMode.CreateNew && File.Exists(path))
            {
                Console.Error.WriteLine("The file {0} already exists", path);

                return false;
            }

            try
            {
                stream = new FileStream(path, mode, access);

                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Could not open file stream: {0}", e.Message);

                return false;
            }
        }

        private static bool OpenPak(string path, out PakFile pakFile)
        {
            pakFile = null;
            FileStream fileStream;

            if (!OpenStream(path, FileMode.Open, FileAccess.Read, out fileStream))
            {
                return false;
            }

            try
            {
                pakFile = new PakFile(fileStream);

                return true;
            }
            catch (PakException e)
            {
                Console.WriteLine("Failed to open pak file {0} > {1}", path, e.Message);

                return false;
            }
        }

        private class CmdArg
        {
            public int ArgCount { get; private set; }
            public CmdArgHandler Handler { get; private set; }

            public CmdArg(int argCount, CmdArgHandler handler)
            {
                this.ArgCount = argCount;
                this.Handler = handler;
            }
        }
    }
}
