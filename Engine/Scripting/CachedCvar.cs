namespace DarkTech.Engine.Scripting
{
    public sealed class CachedCvar<T>
    {
        private CvarBase<T> value;

        public string Name { get; private set; }
        public T DefaultValue { get; private set; }
        public bool HasCache { get { return value != null; } }
        public T Value
        {
            get
            {
                if (!HasCache)
                {
                    AttemptResolve();
                }

                return HasCache ? value.Value : DefaultValue;
            }
            set
            {
                if (!HasCache)
                {
                    AttemptResolve();
                }

                if (HasCache)
                {
                    this.value.Value = value;
                }
            }
        }

        public CachedCvar(string name, T defaultValue)
        {
            this.Name = name;
            this.DefaultValue = defaultValue;
            this.value = null;
        }

        private void AttemptResolve()
        {
            if (Engine.ScriptingInterface.IsCvarRegistered(Name))
            {
                Cvar cvar = Engine.ScriptingInterface.GetCvar(Name);

                if (typeof(CvarBase<T>).IsAssignableFrom(cvar.GetType()))
                {
                    value = (CvarBase<T>)cvar;
                }
            }
        }
    }
}
