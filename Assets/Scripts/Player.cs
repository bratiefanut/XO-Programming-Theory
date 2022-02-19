using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveHorizontal;
    private float moveVertical;
    [SerializeField]
    private float movementSpeed = 3f;

    private Rigidbody2D characterRigidBody;

    // Cache the Rigidbody so we don't need to keep calling it.
    void Start()
    {
        characterRigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        characterRigidBody.velocity = new Vector2(moveHorizontal, moveVertical) * movementSpeed;

    }
}
