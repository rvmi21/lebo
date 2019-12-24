using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movespeed = 5f;

    public Rigidbody2D rb;

    public Animator a;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        a.SetFloat("Horizontal", movement.x);
        a.SetFloat("Vertical", movement.y);
        a.SetFloat("Speed", movement.sqrMagnitude);

        
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
