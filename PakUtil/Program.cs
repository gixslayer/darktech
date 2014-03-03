using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using DarkTech.Engine.Resources.PAK;

namespace DarkTech.PakUtil
{
    static class Program
    {
        private static string[] args;
        private delegate void CmdArgHandler();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Build the command line handling system.
            Dictionary<string, CmdArg> commandArgs = new Dictionary<string, CmdArg>();
            commandArgs.Add("-cli", new CmdArg(0, StartCLI));
            commandArgs.Add("-c", new CmdArg(2, Create));
            commandArgs.Add("-e", new CmdArg(2, ExtractAll));
            commandArgs.Add("-E", new CmdArg(3, Extract));
            commandArgs.Add("-a", new CmdArg(3, Add));
            commandArgs.Add("-r", new CmdArg(2, Remove));
            commandArgs.Add("-R", new CmdArg(3, Rename));
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
                commandLineArguments.CopyTo(args, 1);

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

            // Launch the GUI.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void StartCLI()
        {

        }

        private static void Create()
        {

        }

        private static void ExtractAll()
        {

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

            PakEntry[] entries = pakFile.GetEntries();
            for (int i = 0; i < pakFile.EntryCount; i++)
            {
                PakEntry entry = entries[i];

                Console.WriteLine("{0}\t{1}\t({2}) @ {3} -> {4} bytes", i, entry.Name, (byte)entry.Flags, entry.Offset, entry.Size);
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

            pakFile = new PakFile();

            if (!pakFile.Load(fileStream))
            {
                fileStream.Close();
                fileStream.Dispose();

                Console.Error.WriteLine("Could not open pak file {0}", path);

                return false;
            }

            return true;
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
