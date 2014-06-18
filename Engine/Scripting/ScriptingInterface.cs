using System;
using System.Collections.Generic;

using DarkTech.Common.Math;

namespace DarkTech.Engine.Scripting
{
    public sealed class ScriptingInterface
    {
        private Dictionary<string, Command> commands;
        private Dictionary<string, Cvar> cvars;
        private Dictionary<string, string> aliases;
        private CommandBuffer commandBuffer;

        public ScriptingInterface()
        {
            this.commands = new Dictionary<string, Command>();
            this.cvars = new Dictionary<string, Cvar>();
            this.aliases = new Dictionary<string, string>();
            this.commandBuffer = new CommandBuffer();
        }

        #region Alias
        public void RegisterAlias(string name, string dest)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid name", "name");
            if (!IsCommandRegistered(dest) && !IsCvarRegistered(dest))
                throw new ArgumentException("Unknown destination", "dest");

            if (IsAliasRegistered(name))
            {
                Engine.Warningf("Duplicate alias registration for alias {0}", name);
                UnregisterAlias(name);
            }

            aliases.Add(name, dest);
        }

        public bool IsAliasRegistered(string name)
        {
            return aliases.ContainsKey(name);
        }

        public void UnregisterAlias(string name)
        {
            if (IsAliasRegistered(name))
            {
                aliases.Remove(name);
            }
        }
        #endregion

        #region Command
        public void RegisterCommand(string name, string description, bool cheatProtected, CommandHandler handler)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid name", "name");
            if (handler == null)
                throw new ArgumentNullException("handler");

            if (IsCommandRegistered(name))
            {
                Engine.Warningf("Duplicate command registration for command {0}", name);
                UnregisterCommand(name);
            }

            commands.Add(name, new Command(name, description, cheatProtected, handler));
        }

        public bool IsCommandRegistered(string name)
        {
            return commands.ContainsKey(name);
        }

        public void UnregisterCommand(string name)
        {
            if (IsCommandRegistered(name))
            {
                commands.Remove(name);
            }
        }
        
        public Command GetCommand(string name) 
        {
            if(!IsCommandRegistered(name)) 
                throw new ArgumentException("Command is not registered", "name");

            return commands[name];
        }
        #endregion

        #region Cvar
        public CvarString RegisterCvarString(string name, string description, CvarFlag flags, string defaultValue)
        {
            return RegisterCvar(new CvarString(name, description, flags, defaultValue));
        }

        public CvarBool RegisterCvarBool(string name, string description, CvarFlag flags, bool defaultValue)
        {
            return RegisterCvar(new CvarBool(name, description, flags, defaultValue));
        }

        public CvarEnum<T> RegisterCvarEnum<T>(string name, string description, CvarFlag flags, T defaultValue) where T : struct
        {
            return RegisterCvar(new CvarEnum<T>(name, description, flags, defaultValue));
        }

        public CvarInt RegisterCvarInt(string name, string description, CvarFlag flags, int defaultValue)
        {
            return RegisterCvarInt(name, description, flags, defaultValue, int.MinValue, int.MaxValue);
        }

        public CvarInt RegisterCvarInt(string name, string description, CvarFlag flags, int defaultValue, int minValue, int maxValue)
        {
            return RegisterCvar(new CvarInt(name, description, flags, defaultValue, minValue, maxValue));
        }

        public CvarFloat RegisterCvarFloat(string name, string description, CvarFlag flags, float defaultValue)
        {
            return RegisterCvarFloat(name, description, flags, defaultValue, float.MinValue, float.MaxValue);
        }

        public CvarFloat RegisterCvarFloat(string name, string description, CvarFlag flags, float defaultValue, float minValue, float maxValue)
        {
            return RegisterCvar(new CvarFloat(name, description, flags, defaultValue, minValue, maxValue));
        }

        public CvarVector2f RegisterCvarVector2f(string name, string description, CvarFlag flags, Vector2f defaultValue)
        {
            return RegisterCvarVector2f(name, description, flags, defaultValue, Vector2f.MIN, Vector2f.MAX);
        }

        public CvarVector2f RegisterCvarVector2f(string name, string description, CvarFlag flags, Vector2f defaultValue, Vector2f minValue, Vector2f maxValue)
        {
            return RegisterCvar(new CvarVector2f(name, description, flags, defaultValue, minValue, maxValue));
        }

        public CvarVector3f RegisterCvarVector3f(string name, string description, CvarFlag flags, Vector3f defaultValue)
        {
            return RegisterCvarVector3f(name, description, flags, defaultValue, Vector3f.MIN, Vector3f.MAX);
        }

        public CvarVector3f RegisterCvarVector3f(string name, string description, CvarFlag flags, Vector3f defaultValue, Vector3f minValue, Vector3f maxValue)
        {
            return RegisterCvar(new CvarVector3f(name, description, flags, defaultValue, minValue, maxValue));
        }

        public CvarVector4f RegisterCvarVector4f(string name, string description, CvarFlag flags, Vector4f defaultValue)
        {
            return RegisterCvarVector4f(name, description, flags, defaultValue, Vector4f.MIN, Vector4f.MAX);
        }

        public CvarVector4f RegisterCvarVector4f(string name, string description, CvarFlag flags, Vector4f defaultValue, Vector4f minValue, Vector4f maxValue)
        {
            return RegisterCvar(new CvarVector4f(name, description, flags, defaultValue, minValue, maxValue));
        }

        private T RegisterCvar<T>(T cvar) where T  : Cvar
        {
            if (string.IsNullOrWhiteSpace(cvar.Name))
                throw new ArgumentException("Invalid name", "cvar.Name");

            if (IsCvarRegistered(cvar.Name))
            {
                Engine.Warningf("Duplicate cvar registration for cvar {0}", cvar.Name);
                UnregisterCvar(cvar.Name);
            }

            cvars.Add(cvar.Name, cvar);

            return cvar;
        }

        public bool IsCvarRegistered(string name)
        {
            return cvars.ContainsKey(name);
        }

        public void UnregisterCvar(string name)
        {
            if (IsCvarRegistered(name))
            {
                cvars.Remove(name);
            }
        }

        public Cvar GetCvar(string name)
        {
            if (!IsCvarRegistered(name))
                throw new ArgumentException("Cvar is not registered", "name");

            return cvars[name];
        }

        public T GetCvar<T>(string name) where T : Cvar
        {
            Cvar cvar = GetCvar(name);

            if (!typeof(T).IsAssignableFrom(cvar.GetType()))
                throw new InvalidCastException(string.Format("Could not assign cvar {0} of type {1} to type {2}", name, cvar.GetType().FullName, typeof(T).FullName));

            return (T)cvar;
        }

        public string GetCvarValue(string name)
        {
            return GetCvar(name).ToString();
        }

        public T GetCvarValue<T>(string name)
        {
            Cvar cvar = GetCvar(name);
            Type expected = typeof(CvarBase<T>);

            if (!expected.IsAssignableFrom(cvar.GetType()))
                throw new ArgumentException("Invalid cvar type");

            return ((CvarBase<T>)cvar).Value;
        }

        public void RegisterCvarCallback<T>(string name, CvarCallback<T> callback)
        {
            if (!IsCvarRegistered(name))
                throw new ArgumentException("Cvar is not registered", "name");
            if (!(cvars[name] is CvarBase<T>))
                throw new ArgumentException("Cvar/Callback type mismatch");

            ((CvarBase<T>)cvars[name]).RegisterCallback(callback);
        }
        #endregion

        #region Execute
        public void Execute(string statement)
        {
            ArgList args = new ArgList();

            args.Parse(statement);

            if (args.Count == 0)
            {
                Engine.Warning("Attempted to execute empty statement");

                return;
            }

            Arg arg = args.Next;

            // Resolve alias if registered.
            if (aliases.ContainsKey(arg))
            {
                arg = aliases[arg];
            }

            if (IsCommandRegistered(arg))
            {
                ExecuteCommand(ExecuteMode.Append, arg, args);
            }
            else if (IsCvarRegistered(arg))
            {
                if (args.Count == 0)
                {
                    // Print cvar value.
                    Engine.Printf("{0} = {1}", arg, GetCvarValue(arg));
                }
                else
                {
                    // Assign cvar value.
                    GetCvar(arg).Parse(args);
                }
            }
            else
            {
                Engine.Errorf("Unknown command/cvar {0}", arg);
            }
        }

        public void ExecuteCommand(ExecuteMode mode, string name, string argString)
        {
            ArgList args = new ArgList();

            args.Parse(argString);

            ExecuteCommand(mode, name, args);
        }

        public void ExecuteCommand(ExecuteMode mode, string name, ArgList args)
        {
            if (IsAliasRegistered(name))
            {
                name = aliases[name];
            }

            if (!IsCommandRegistered(name))
            {
                Engine.Errorf("Could not find command {0}", name);

                return;
            }

            switch (mode)
            {
                case ExecuteMode.Append:
                    commandBuffer.Append(commands[name], args);
                    break;
                case ExecuteMode.Immediate:
                    commands[name].Execute(args);
                    break;
                case ExecuteMode.Insert:
                    commandBuffer.Insert(commands[name], args);
                    break;
            }
        }
        #endregion
    }
}
