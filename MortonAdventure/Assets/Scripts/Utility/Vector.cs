using UnityEngine;

namespace Utility
{
    public class Vector : MonoBehaviour
    {
        public static bool IsLengthZero(Vector2 dir)
        {
            return dir.sqrMagnitude == 0;
        }
    }
}
