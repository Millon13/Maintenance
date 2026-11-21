using UnityEngine;

namespace DefaultNamespace.MapScripts
{
    public class MapArror : MonoBehaviour
    {

        public Transform playerTransform;

        void LateUpdate()
        {
            if (playerTransform == null) return;
            
            float playerYRotation = playerTransform.eulerAngles.y;
            transform.rotation = Quaternion.Euler(90f, playerYRotation, 0f);
        }

    }
}