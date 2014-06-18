using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace DarkTech.Engine
{
    public abstract class Event
    {
        private static readonly Dictionary<Type, EventType> TYPE_MAPPING = new Dictionary<Type, EventType>();

        static Event()
        {
            // Build type mapping.
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (!type.IsClass || type.IsAbstract)
                    continue;
                if (!type.IsSubclassOf(typeof(Event)))
                    continue;
                if (type.ContainsGenericParameters)
                    continue;

                if (!TYPE_MAPPING.ContainsKey(type))
                {
                    try
                    {
                        Event e = (Event)Activator.CreateInstance(type);

                        TYPE_MAPPING.Add(type, e.Type);
                    }
                    catch (Exception e)
                    {
                        //Debug.Fail("Failed to create instance for type", "Failed to create instance for Event type " + type.FullName + " > " + e.Message);
                    }
                }
                else
                {
                    //Debug.Fail("Duplicate type mapping", "Duplicate type mapping for Event " + type.FullName);
                }
            }
        }

        public EventType Type { get; private set; }

        public Event(EventType type)
        {
            this.Type = type;
        }

        public abstract void Serialize(Stream stream);
        public abstract void Deserialize(Stream stream);

        internal static EventType GetEventType<T>() where T : Event
        {
            Type type = typeof(T);

            if (!TYPE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Unmapped generic type", "T");

            return TYPE_MAPPING[type];
        }
    }
}
