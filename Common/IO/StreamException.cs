namespace DarkTech.Common.IO
{
    public class StreamException : System.Exception
    {
        public static readonly StreamException UNEXPECTED_EOS = new StreamException("Unexpected end of stream");

        public StreamException(string message) : base(message) { }
    }
}