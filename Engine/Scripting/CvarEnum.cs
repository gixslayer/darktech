using System;

namespace DarkTech.Engine.Scripting
{
    public sealed class CvarEnum<T> : CvarBase<T> where T : struct
    {
        public CvarEnum(string name, string description, CvarFlag flags, T defaultValue)
            : base(name, description, flags, defaultValue)
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Generic type must be an enum");
            }
        }

        protected override bool TryParse(ArgList args, out T result)
        {
            result = default(T);

            if (args.Count == 0)
            {
                return false;
            }

            Arg token = args.Next;

            if (!Enum.TryParse<T>(token, out result))
            {
                return false;
            }

            return Enum.IsDefined(typeof(T), result);
        }
    }
}
