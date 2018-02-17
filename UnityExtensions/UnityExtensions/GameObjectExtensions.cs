using UnityEngine;

namespace UnityExtensions
{
    public static class GameObjectExtensions
    {
        public static void SetLayerRecursively(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;
            foreach(Transform transform in gameObject.transform)
                transform.gameObject.layer = layer;
        }
    }
}