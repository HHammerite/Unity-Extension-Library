using UnityEngine;

namespace UnityExtensions
{
    public static class LayerMaskExtensions
    {
        /// <summary>
        /// Checks if a layer is present in the mask
        /// </summary>
        /// <param name="layerMask"></param>
        /// <param name="layer"></param>
        /// <returns></returns>
        public static bool Contains(this LayerMask layerMask, int layer)
        {
            return layerMask == (layerMask | (1 << layer));
        }
    }
}