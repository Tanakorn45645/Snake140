using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;


    public Rigidbody2D rb;

    Vector2 movement;

    void Update()
{
    // Reset movement to zero before checking for new input
    movement = Vector2.zero;

    if (Input.GetKey(left))
    {
        movement.x = -1f;
    }
    else if (Input.GetKey(right))
    {
        movement.x = 1f;
    }

    if (Input.GetKey(up))
    {
        movement.y = 1f;
    }
    else if (Input.GetKey(down))
    {
        movement.y = -1f;
    }
}

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
