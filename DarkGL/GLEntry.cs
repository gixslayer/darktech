using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Attribute for OpenGL entries
    /// </summary>
    internal sealed class GLEntry : Attribute
    {
        /// <summary>
        /// Function name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// GL category (used extension)
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// List of possible alias names of function
        /// </summary>
        public string Alias { get; set; }

        public GLEntry(string entryName) 
        { 
            this.Name = entryName; 
        }
    }    
}
