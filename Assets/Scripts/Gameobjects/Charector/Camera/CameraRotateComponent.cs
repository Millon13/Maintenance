using UnityEngine;

namespace DefaultNamespace
{
    public class CameraRotateComponent : MonoBehaviour
    {
        public float sensitivity = 3f;
        private float lastMouseX;

        void Start()
        {
            lastMouseX = Input.mousePosition.x;
        }

        void Update()
        {
            float currentMouseX = Input.mousePosition.x;
            float deltaX = currentMouseX - lastMouseX;
            lastMouseX = currentMouseX;

            transform.Rotate(0f, deltaX * sensitivity, 0f, Space.World);
        }
    }

}