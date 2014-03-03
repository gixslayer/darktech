namespace DarkTech.Engine.Scripting
{
    public enum CvarFlag : uint
    {
        None = 0,
        /// <summary>
        /// The Cvar is ROM. No changes can be made from the initial value.
        /// </summary>
        ReadOnly = 1,
        /// <summary>
        /// The Cvar is write protected. No changes can be made through the scripting interface. The value can only be modified by directly setting it on the Cvar instance.
        /// </summary>
        WriteProtected = 2,
        /// <summary>
        /// The Cvar is cheat protected. No changes can be made unless cheats are enabled.
        /// </summary>
        CheatProtected = 4,
        /// <summary>
        /// The Cvar value is been marked as modified.
        /// </summary>
        Modified = 8,
        All = uint.MaxValue
    }
}
