using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] KeyCode moveForward = KeyCode.W;
    [SerializeField] KeyCode moveBackward = KeyCode.S;
    [SerializeField] KeyCode moveLeft = KeyCode.A;
    [SerializeField] KeyCode moveRight = KeyCode.D;
    [SerializeField] private float speed = 5f;
 
    
    void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(moveForward))
            direction += Vector3.forward;

        if (Input.GetKey(moveBackward))
            direction += Vector3.back;

        if (Input.GetKey(moveLeft))
            direction += Vector3.left;

        if (Input.GetKey(moveRight))
            direction += Vector3.right;

        transform.Translate(direction *speed* Time.deltaTime);

    }
}
