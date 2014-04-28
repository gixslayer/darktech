using System;
using System.IO;

using DarkTech.Common.BBS;
using DarkTech.Common.IO;

namespace DarkTech.BBS2Text
{
    class Program
    {
        /// <summary>
        /// Program ran without any errors.
        /// </summary>
        const int ERR_SUCCESS = 0;
        /// <summary>
        /// The input BBS file could not be found.
        /// </summary>
        const int ERR_IF_NOT_FOUND = -1;
        /// <summary>
        /// The output text file could not be opened.
        /// </summary>
        const int ERR_OF = -2;
        /// <summary>
        /// The input file stream could not be opened.
        /// </summary>
        const int ERR_IF_STREAM_EXCEPTION = -3;
        /// <summary>
        /// The input BBS file could not be loaded.
        /// </summary>
        const int ERR_IF_BBS_EXCEPTION = -4;

        static IndentWriter writer = null;

        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
                PrintUsage();

            string inputPath;
            string outputPath;

            if (!File.Exists(args[0]))
            {
                Console.Error.WriteLine("Could not find input BBS file {0}", args[0]);

                Environment.Exit(ERR_IF_NOT_FOUND);
            }

            inputPath = args[0];
            outputPath = args.Length > 1 ? args[1] : string.Concat(inputPath, ".txt");

            Console.WriteLine("Opening streams and loading BBS file");

            OpenOutput(outputPath);
            BBSFile input = OpenBBSFile(inputPath);

            Console.WriteLine("Converting BBS file {0} to text file {1}", inputPath, outputPath);

            Convert(input);

            Console.WriteLine("Completed successfully");

            Environment.Exit(ERR_SUCCESS);
        }

        static BBSFile OpenBBSFile(string path)
        {
            BBSFile file = new BBSFile();
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                file.Load(fileStream);

                return file;
            }
            catch (StreamException streamException)
            {
                Console.Error.WriteLine("Could not load BBS file > {0}", streamException.Message);

                fileStream.Close();
                fileStream.Dispose();

                Environment.Exit(ERR_IF_BBS_EXCEPTION);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Could not open input file stream > {0}", e.Message);

                Environment.Exit(ERR_IF_STREAM_EXCEPTION);
            }

            // Dead code but compiler doesn't seem to pick up on this. Granted this isn't exactly pretty programming though.
            return null;
        }

        static void OpenOutput(string path)
        {
            try
            {
                writer = new IndentWriter(path);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Could not open output file > {0}", e.Message);

                Environment.Exit(ERR_OF);
            }
        }

        static void Convert(BBSFile input)
        {
            BlockNode root = input.Root;

            foreach (string blockName in root.Keys)
            {
                WriteBlock(root[blockName], blockName);
            }
        }

        static void WriteBlock(Block block, string name = null)
        {
            // Format
            // [Name:"name", Type:blockType, Length:length]
            // {
            //      Data
            // }
            //
            // Name: If it's a named block.
            // Type: Always. 
            // Length: If it's an array.
            // Data: Create specific methods for each block type?

            writer.Write("[");

            if (name != null)
            {
                writer.Write("Name:\"{0}\", ", name);
            }

            writer.Write("Type:{0}", block.Type.ToString());

            // Handle array length.
            int length = GetArrayLength(block);

            if (length != -1)
            {
                writer.Write(", Length:{0}", length);
            }

            writer.WriteLine("]");

            writer.WriteLine("{");

            writer.IncreaseIndent();
            WriteBlockData(block);
            writer.DecreaseIndent();

            writer.WriteLine("}");
        }

        static int GetArrayLength(Block block)
        {
            switch (block.Type)
            {
                case BlockType.BoolArray:
                    return (block as BlockBoolArray).Length;
                case BlockType.ByteArray:
                    return (block as BlockBoolArray).Length;
                case BlockType.CharArray:
                    return (block as BlockCharArray).Length;
                case BlockType.DoubleArray:
                    return (block as BlockDoubleArray).Length;
                case BlockType.FloatArray:
                    return (block as BlockFloatArray).Length;
                case BlockType.IntArray:
                    return (block as BlockIntArray).Length;
                case BlockType.ListArray:
                    return (block as BlockListArray).Length;
                case BlockType.LongArray:
                    return (block as BlockLongArray).Length;
                case BlockType.NodeArray:
                    return (block as BlockNodeArray).Length;
                case BlockType.SByteArray:
                    return (block as BlockSByteArray).Length;
                case BlockType.ShortArray:
                    return (block as BlockShortArray).Length;
                case BlockType.StringArray:
                    return (block as BlockStringArray).Length;
                case BlockType.StringExArray:
                    return (block as BlockStringExArray).Length;
                case BlockType.UIntArray:
                    return (block as BlockUIntArray).Length;
                case BlockType.ULongArray:
                    return (block as BlockULongArray).Length;
                case BlockType.UShortArray:
                    return (block as BlockUShortArray).Length;
                default:
                    return -1;
            }
        }

        static void WriteBlockData(Block block)
        {

        }

        static void PrintUsage()
        {
            Console.WriteLine("Usage: BBS2Text input [output]");
            Console.WriteLine("input: The path to the input BBS file");
            Console.WriteLine("output: The path to the output text file. If omitted '.txt' will be appended to the input path and that path is used instead");

            Environment.Exit(ERR_SUCCESS);
        }
    }
}
