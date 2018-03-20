using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace UnityExtensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Resets the transform's position & rotation respectively. 
        /// </summary>
        /// <param name="transform"></param>
        public static void Reset(this Transform transform)
        {
            transform.rotation = Quaternion.identity;
            transform.position = Vector3.zero;
        }
        
        /// <summary>
        /// Lerps this transforms position to a new position over the given time.
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="position"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static IEnumerator MoveToPosition(this Transform transform, Vector3 position, float duration)
        {
            var currentPos = transform.position;
            var t = 0f;
            while(t < 1)
            {
                t += Time.deltaTime / duration;
                transform.position = Vector3.Lerp(currentPos, position, t);
                yield return null;
            }
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