namespace DarkTech.Engine.Resources
{
    public sealed class DuplicateResourceException : ResourceException
    {
        public DuplicateResourceException(string resource) : base("Resource {0} is already loaded as another type", resource) { }
    }
}
