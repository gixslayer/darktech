using System;

namespace DarkTech.DarkGL
{
    /// <summary>
    /// Attribute for OpenGL entries
    /// </summary>
    internal class GLEntry : Attribute
    {
        string name;
        string category;
        string alias;

        public GLEntry(string entryName) { name = entryName; }
        
        /// <summary>
        /// Function name
        /// </summary>
        public string Name { get { return name; } }
        
        /// <summary>
        /// GL category (used extension)
        /// </summary>
        public string Category { get { return category; } set { category = value; } }
        
        /// <summary>
        /// List of possible alias names of function
        /// </summary>
        public string Alias { get { return alias; } set { alias = value; } }
    }    
}
