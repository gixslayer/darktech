using System.Collections.Generic;

namespace DarkTech.Engine
{
    public sealed class SceneGraph
    {
        private Dictionary<uint, Entity> entityLookup;
        private EntityGroup root;
        private uint nextEntityId;

        public EntityGroup Root { get { return root; } }

        public SceneGraph()
        {
            this.entityLookup = new Dictionary<uint, Entity>();
            this.root = new EntityGroup();
            this.nextEntityId = 0;
        }

        #region Entity
        public bool HasEntity(uint id)
        {
            return entityLookup.ContainsKey(id);
        }

        public Entity GetEntity(uint id)
        {
            if (!HasEntity(id))
            {
                return null;
            }

            return entityLookup[id];
        }

        internal void RegisterEntity(Entity entity)
        {
            if (entity.Id == uint.MaxValue)
            {
                Engine.Errorf("Invalid entity id {0}", entity.Id);
                return;
            }

            if (entityLookup.ContainsKey(entity.Id))
            {
                Engine.Errorf("Duplicate entity id {0}", entity.Id);
                return;
            }

            entityLookup.Add(entity.Id, entity);
        }

        internal void UnregisterEntity(Entity entity)
        {
            UnregisterEntity(entity.Id);
        }

        internal void UnregisterEntity(uint id)
        {
            entityLookup.Remove(id);
        }

        internal uint GetEntityId()
        {
            // TODO: Start from current point and wrap around till the same point is reached. Only then there is an actual overflow.
            if (nextEntityId == uint.MaxValue)
            {
                Engine.Error("Entity id overflow");

                return uint.MaxValue;
            }
            else
            {
                return nextEntityId++;
            }
        }
        #endregion
    }
}
