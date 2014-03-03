namespace DarkTech.Engine
{
    public class EntityGroup : NamedEntity
    {
        private EntityList children;

        public bool SuppressChildUpdate { get; set; } // Suppress all child entity updates.
        public bool SuppressChildRender { get; set; } // Suppress all child entity renders.

        public EntityGroup() : base("root")
        {
            this.children = new EntityList();

            SuppressChildUpdate = false;
            SuppressChildRender = false;
        }

        #region Entity
        public void AddEntity(Entity entity)
        {
#if DEBUG
            if (entity == null)
            {
                throw new System.ArgumentNullException("entity");
            }
#endif

            children.Add(entity);

            Engine.Scene.RegisterEntity(entity);
        }

        public bool HasEntity(Entity entity)
        {
#if DEBUG
            if (entity == null)
            {
                throw new System.ArgumentNullException("entity");
            }
#endif

            return children.Contains(entity);
        }

        public bool HasEntity(uint id)
        {
            Entity entity = Engine.Scene.GetEntity(id);

            if (entity == null)
            {
                return false;
            }

            return HasEntity(entity);
        }

        public void RemoveEntity(Entity entity)
        {
#if DEBUG
            if (entity == null)
            {
                throw new System.ArgumentNullException("entity");
            }
#endif

            if (children.Remove(entity))
            {
                Engine.Scene.UnregisterEntity(entity);
            }
        }

        public void RemoveEntity(uint id)
        {
            Entity entity = Engine.Scene.GetEntity(id);

            if (entity != null)
            {
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
