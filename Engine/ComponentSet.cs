using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Engine
{
    internal sealed class ComponentSet : IEnumerable
    {
        private readonly Dictionary<Type, Component> componentMap;

        public int Count { get { return componentMap.Count; } }

        public ComponentSet()
        {
            this.componentMap = new Dictionary<Type, Component>();
        }

        public void Add(Component component)
        {
            if(component == null)
                throw new ArgumentNullException("component");

            Type type = component.GetType();

            if (componentMap.ContainsKey(type))
                throw new ArgumentException("Component type already in set", "component");

            componentMap.Add(type, component);
        }

        public bool Contains<T>() where T : Component
        {
            return componentMap.ContainsKey(typeof(T));
        }

        public void Remove<T>() where T : Component
        {
            if (Contains<T>())
            {
                componentMap.Remove(typeof(T));
            }
        }

        public T Get<T>() where T : Component
        {
            if (!Contains<T>())
                throw new ArgumentException("Component type not in set", "T");

            return componentMap[typeof(T)] as T;
        }

        public IEnumerator GetEnumerator()
        {
            return componentMap.Values.GetEnumerator();
        }
    }
}
