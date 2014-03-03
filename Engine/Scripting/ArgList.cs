using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DarkTech.Engine.Scripting
{
    public sealed class ArgList : IEnumerable
    {
        public static readonly ArgList EMPTY = new ArgList();

        public const char QUOTE = '"';
        public const char SPACE = ' ';

        private List<Arg> args;

        public int Count { get { return args.Count; } }
        public bool HasNext { get { return args.Count != 0; } }
        public Arg Peek 
        { 
            get 
            {
                if (!HasNext)
                {
                    throw new InvalidOperationException("No token is available");
                }

                return args[0];
            } 
        }
        public Arg Next
        {
            get
            {
                if (!HasNext)
                {
                    throw new InvalidOperationException("No token is available");
                }

                Arg token = args[0];
                args.RemoveAt(0);

                return token;
            }
        }

        public ArgList()
        {
            this.args = new List<Arg>();
        }

        public Arg this[int index]
        {
            get
            {
                if (index < 0 || index >= args.Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                return args[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return args.GetEnumerator();
        }

        public void Parse(string value)
        {
            bool insideQuotes = false;
            StringBuilder buffer = new StringBuilder();
            string bufferValue;

            args.Clear();

            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];

                if (c == QUOTE)
                {
                    insideQuotes = !insideQuotes;
                }
                else if (c == SPACE)
                {
                    bufferValue = buffer.ToString();
                    buffer.Clear();

                    ParseArg(bufferValue);
                }
                else
                {
                    buffer.Append(c);
                }
            }

            if (buffer.Length != 0)
            {
                bufferValue = buffer.ToString();
                buffer.Clear();

                ParseArg(bufferValue);
            }
        }

        private void ParseArg(string value)
        {
            float fResult;
            int iResult;

            if (float.TryParse(value, out fResult))
            {
                args.Add(new Arg(ArgType.Numeric, value, fResult, (int)fResult));
            }
            else if (int.TryParse(value, out iResult))
            {
                // FIXME: Can a failed float parse ever be a legit int parse?
                args.Add(new Arg(ArgType.Numeric, value, iResult, iResult));
            }
            else
            {
                args.Add(new Arg(ArgType.String, value, 0f, 0));
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < args.Count; i++)
            {
                stringBuilder.Append(args[i].StringValue);

                if (i + 1 != args.Count)
                {
                    stringBuilder.Append(SPACE);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
