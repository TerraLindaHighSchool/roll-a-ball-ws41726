using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private RigidBody rb;
    private float movementX;
    Private float movementY;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = getComponent<Rigidbody>();
    }

    
    Void OnMove(InputValue movementValue)
    {
	Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
	movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);   
 
	rb.AddForce(movememt);
    }

}
