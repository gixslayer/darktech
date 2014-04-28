using System.Collections.Generic;

namespace DarkTech.Engine.Scripting
{
    public delegate void CvarCallback<T>(string name, T oldValue, T newValue);

    public abstract class CvarBase<T> : Cvar
    {
        private T value;
        private readonly List<CvarCallback<T>> callbacks;

        public T DefaultValue { get; private set; }
        public T Value
        {
            get { return value; }
            set { Set(value); }
        }
        
        internal CvarBase(string name, string description, CvarFlag flags, T defaultValue) : base(name, description, flags)
        {
            this.value = defaultValue;
            this.DefaultValue = defaultValue;
            this.callbacks = new List<CvarCallback<T>>();
        }

        public void RegisterCallback(CvarCallback<T> callback)
        {
            if (callback == null)
                throw new System.ArgumentNullException("callback");

            callbacks.Add(callback);
        }

        public void Reset()
        {
            if (!this.value.Equals(DefaultValue))
            {
                this.value = DefaultValue;

                SetFlag(CvarFlag.Modified);
            }
        }

        public override void Parse(ArgList args)
        {
            if (HasFlag(CvarFlag.WriteProtected))
            {
                Engine.Errorf("Cvar {0} is write protected", Name);

                return;
            }

            T result;

            if (!TryParse(args, out result))
            {
                Engine.Errorf("Could not parse value {0} for cvar {1}", value, Name);

                return;
            }

            if (!IsValidValue(result))
            {
                Engine.Errorf("Value {0} is not valid for cvar {1}", value, Name);

                return;
            }

            Set(result);
        }

        public override string ToString()
        {
 	        return value.ToString();
        }

        protected virtual bool IsValidValue(T value) { return true;  }

        protected abstract bool TryParse(ArgList args, out T result);

        private void Set(T value)
        {
            if (HasFlag(CvarFlag.ReadOnly))
            {
                Engine.Errorf("Cvar {0} is read only", Name);

                return;
            }

            if (HasFlag(CvarFlag.CheatProtected) && !Engine.CheatsEnabled)
            {
                Engine.Errorf("Cvar {0} is cheat protected", Name);

                return;
            }

            if (!this.value.Equals(value))
            {
                T oldValue = this.value;

                this.value = value;

                SetFlag(CvarFlag.Modified);

                foreach (CvarCallback<T> callback in callbacks)
                {
                    callback(Name, oldValue, value);
                }
            }
        }

        public static implicit operator T(CvarBase<T> cvar)
        {
            return cvar.Value;
        }
    }
}
