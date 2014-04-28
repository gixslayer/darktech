using System;
using System.IO;

namespace DarkTech.Common.IO
{
    public class IndentWriter
    {
        private readonly StreamWriter writer;
        private int indent;

        public int Indent { get { return indent; } }

        public IndentWriter(string path)
        {
            this.writer = new StreamWriter(path);
        }

        public IndentWriter(Stream stream)
        {
            this.writer = new StreamWriter(stream);
        }

        public void IncreaseIndent()
        {
            ChangeIndent(1);
        }

        public void DecreaseIndent()
        {
            ChangeIndent(-1);
        }

        public void ChangeIndent(int dIndent)
        {
            SetIndent(indent + dIndent);
        }

        public void SetIndent(int indent)
        {
            if (indent < 0)
                throw new ArgumentOutOfRangeException("indent");

            this.indent = indent;
        }

        public void Write(string text)
        {
            string finalText = text;

            if (indent != 0)
            {
                // TODO: Should use a StringWriter instead of an ugly string concatenation loop.
                for (int i = 0; i < indent; i++)
                {
                    finalText = string.Concat("\t", finalText);
                }
            }

            writer.Write(finalText);
        }

        public void Write(string format, params object[] args)
        {
            Write(string.Format(format, args));
        }

        public void WriteLine(string text)
        {
            Write(text);
            WriteLine();
        }

        public void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(format, args));
        }

        public void WriteLine()
        {
            writer.WriteLine();
        }

        public void Dispose()
        {
            writer.Close();
            writer.Dispose();
        }
    }
}
