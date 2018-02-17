using UnityEngine;

namespace UnityExtensions
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Sets the XY values to 0.
        /// </summary>
        /// <param name="vector"></param>
        public static void Reset(this Vector2 vector)
        {
            vector = Vector2.zero;
        }
    }
}