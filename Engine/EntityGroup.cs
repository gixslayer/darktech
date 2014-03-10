using System;
using System.Collections.Generic;

namespace DarkTech.Engine
{
    public class EntityGroup : NamedEntity
    {
        private List<Entity> children;

        public bool SuppressChildUpdate { get; set; } // Suppress all child entity updates.
        public bool SuppressChildRender { get; set; } // Suppress all child entity renders.

        public EntityGroup() : base("root")
        {
            this.children = new List<Entity>();
            this.SuppressChildUpdate = false;
            this.SuppressChildRender = false;
        }

        #region Entity
        public void AddEntity(Entity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            children.Add(entity);

            Engine.Scene.RegisterEntity(entity);
        }

        public bool HasEntity(Entity entity)
        {
            return children.Contains(entity);
        }

        public bool HasEntity(uint id)
        {
            if (!Engine.Scene.HasEntity(id))
            {
                return false;
            }
                
            Entity entity = Engine.Scene.GetEntity(id);

            return HasEntity(entity);
        }

        public void RemoveEntity(Entity entity)
        {
            if (children.Remove(entity))
            {
                Engine.Scene.UnregisterEntity(entity);
            }
        }

        public void RemoveEntity(uint id)
        {
            if (Engine.Scene.HasEntity(id))
            {
                Entity entity = Engine.Scene.GetEntity(id);

                RemoveEntity(entity);
            }
        }
        #endregion

        internal override void Update(float dt)
        {
            base.Update(dt);

            if (!SuppressChildUpdate)
            {
                foreach (Entity entity in children)
                {
                    entity.Update(dt);
                }
            }
        }

        internal override void Render()
        {
            base.Render();

            if (!SuppressChildRender)
            {
                foreach (Entity entity in children)
                {
                    entity.Render();
                }
            }
        }
    }
}
