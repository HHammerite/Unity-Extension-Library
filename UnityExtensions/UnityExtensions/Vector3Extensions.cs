using UnityEngine;

namespace UnityExtensions
{
    public static class Vector3Extensions
    {
        
        /// <summary>
        /// Sets the XYZ values to 0.
        /// </summary>
        /// <param name="vector"></param>
        public static void Reset(this Vector3 vector)
        {
            vector = Vector3.zero;
        }
        
        /// <summary>
        /// Returns the x & y values as a Vector 2.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Vector2 xy(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.y);
        }
        
        /// <summary>
        /// Returns the x & z values as a Vector 2.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Vector2 xz(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }
        
        /// <summary>
        /// Returns the y & z values as a Vector 2.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Vector2 yz(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.z);
        }
        
        
    }
}