namespace DarkTech.Engine
{
    public abstract class Component
    {
        protected Entity entity;

        public bool SuppressUpdate { get; set; }
        public bool SuppressRender { get; set; }

        public Component()
        {
            this.entity = null;
            this.SuppressUpdate = false;
            this.SuppressRender = false;
        }

        internal void SetEntity(Entity entity)
        {
            this.entity = entity;
        }

        public virtual void Update(float dt) { }
        public virtual void Render() { }
    }
}
