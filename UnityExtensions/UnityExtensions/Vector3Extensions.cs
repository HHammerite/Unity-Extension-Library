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

        public static Vector3 GetCenterPoint(this Vector3 point, params Vector3[] points)
        {
            return GetCenterPoint(point, points.ToList());
        }

        public static Vector3 GetCenterPoint(this Vector3 point, List<Vector3> points)
        {
            var centerPoint = new Vector3();

            float x = 0, y = 0, z = 0;

            foreach (var p in points)
            {
                x += p.x;
                y += p.y;
                z += p.z;
            }

            centerPoint.x = x / 4;
            centerPoint.y = y / 4;
            centerPoint.z = z / 4;

            return centerPoint;
        }
    }
}