namespace DarkTech.Engine.Scripting
{
    public enum ExecuteMode
    {
        /// <summary>
        /// Append the command execution to the end of the command buffer.
        /// </summary>
        Append,
        /// <summary>
        /// Insert the command execution to the start of the command buffer.
        /// </summary>
        Insert,
        /// <summary>
        /// Execute the command immediately.
        /// </summary>
        Immediate
    }
}
