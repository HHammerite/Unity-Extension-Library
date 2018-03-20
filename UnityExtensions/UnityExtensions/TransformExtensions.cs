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
        
        
    }
}