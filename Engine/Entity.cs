namespace DarkTech.Engine
{
    public class Entity
    {
        private ComponentSet components;

        public bool SuppressUpdate { get; set; } // Suppress all component updates regardless of their property.
        public bool SuppressRender { get; set; } // Suppress all component renders regardless of their property.
        public uint Id { get; private set; }

        public Entity()
        {
            this.components = new ComponentSet();
            
            SuppressUpdate = false;
            SuppressRender = false;
            Id = Engine.Scene.GetEntityId();
        }

        #region Component
        public void AddComponent(Component component)
        {
#if DEBUG
            if (component == null)
            {
                throw new System.ArgumentNullException("component");
            }
#endif

            component.SetEntity(this);

            components.Add(component);
        }

        public bool HasComponent<T>() where T : Component
        {
            return components.Contains<T>();
        }

        public void RemoveComponent<T>() where T : Component
        {
            components.Remove<T>();
        }

        public T GetComponent<T>() where T : Component
        {
            return components.Get<T>();
        }
        #endregion

        // Any changes to the components list while in the update call should be done in this method to prevent modifying while enumerating.
        protected virtual void PreUpdate(float dt) { }

        internal virtual void Update(float dt)
        {
            if (!SuppressUpdate)
            {
                PreUpdate(dt);

                foreach (Component component in components)
                {
                    if (!component.SuppressUpdate)
                    {
                        component.Update(dt);
                    }
                }
            }
        }

        internal virtual void Render()
        {
            if (!SuppressRender)
            {
                foreach (Component component in components)
                {
                    if (!component.SuppressRender)
                    {
                        component.Render();
                    }
                }
            }
        }

        public override string ToString()
        {
            return string.Format("entity {0}", Id);
        }
    }
}
