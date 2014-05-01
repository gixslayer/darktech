using System;
using System.Collections.Generic;

namespace DarkTech.Common.Utils
{
    /// <summary>
    /// Provides a double linked map between a <paramref name="TKey"/> and <paramref name="TValue"/>.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public class LinkedMap<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> keyMap;
        private readonly Dictionary<TValue, TKey> valueMap;

        /// <summary>
        /// The amount of entries in the map.
        /// </summary>
        public int Count { get { return keyMap.Count; } }
        /// <summary>
        /// The collection of keys in the map.
        /// </summary>
        public Dictionary<TKey, TValue>.KeyCollection Keys
        {
            get { return keyMap.Keys; }
        }
        /// <summary>
        /// The collection of values in the map.
        /// </summary>
        public Dictionary<TKey, TValue>.ValueCollection Values
        {
            get { return keyMap.Values; }
        }

        /// <summary>
        /// Creates a new double linked map without any entries.
        /// </summary>
        public LinkedMap()
        {
            this.keyMap = new Dictionary<TKey, TValue>();
            this.valueMap = new Dictionary<TValue, TKey>();
        }

        /// <summary>
        /// Adds a new entry to the map.
        /// </summary>
        /// <param name="key">The key to add.</param>
        /// <param name="value">The value to add.</param>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="key"/> already exists in the map.</exception>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="value"/> already exists in the map.</exception>
        public void Add(TKey key, TValue value)
        {
            if (keyMap.ContainsKey(key))
                throw new ArgumentException("Duplicate key entry", "key");
            if (valueMap.ContainsKey(value))
                throw new ArgumentException("Duplicate key entry", "value");

            keyMap.Add(key, value);
            valueMap.Add(value, key);
        }

        /// <summary>
        /// Returns the value linked to the <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The key linked the value to return.</param>
        /// <returns>Returns the value linked to the <paramref name="key"/>.</returns>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="key"/> does not exist.</exception>
        public TValue GetByKey(TKey key)
        {
            if(!keyMap.ContainsKey(key))
                throw new ArgumentException("Map does not contain key", "key");

            return keyMap[key];
        }

        /// <summary>
        /// Returns the key linked to the <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value linked to the key to return.</param>
        /// <returns>Returns the key linked to the <paramref name="value"/>.</returns>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="value"/> does not exist.</exception>
        public TKey GetByValue(TValue value)
        {
            if (!valueMap.ContainsKey(value))
                throw new ArgumentException("Map does not contain key", "value");

            return valueMap[value];
        }

        /// <summary>
        /// Checks if the specified <paramref name="key"/> exists in the map.
        /// </summary>
        /// <param name="key">The key to check.</param>
        /// <returns>Returns <c>true</c> if the specified <paramref name="key"/> exists, otherwise <c>false</c> is returned.</returns>
        public bool ContainsKey(TKey key)
        {
            return keyMap.ContainsKey(key);
        }

        /// <summary>
        /// Checks if the specified <paramref name="value"/> exists in the map.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns <c>true</c> if the specified <paramref name="value"/> exists, otherwise <c>false</c> is returned.</returns>
        public bool ContainsValue(TValue value)
        {
            return valueMap.ContainsKey(value);
        }

        /// <summary>
        /// Removes an entry specified by the <paramref name="key"/> from the map.
        /// If no entry is found with the specified <paramref name="key"/> no further action is taken.
        /// </summary>
        /// <param name="key">The key of the entry to remove.</param>
        public void RemoveByKey(TKey key)
        {
            if (keyMap.ContainsKey(key))
            {
                TValue value = keyMap[key];

                keyMap.Remove(key);
                valueMap.Remove(value);
            }
        }

        /// <summary>
        /// Removes an entry specified by the <paramref name="value"/> from the map.
        /// If no entry is found with the specified <paramref name="value"/> no further action is taken.
        /// </summary>
        /// <param name="value">The value of the entry to remove.</param>
        public void RemoveByValue(TValue value)
        {
            if (valueMap.ContainsKey(value))
            {
                TKey key = valueMap[value];

                keyMap.Remove(key);
                valueMap.Remove(value);
            }
        }
    }
}
