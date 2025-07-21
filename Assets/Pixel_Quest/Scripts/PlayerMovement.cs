using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;                        // Reference variable
    private SpriteRenderer _spriteRenderer;        // controles player image
    public int speed = 4;                          // You can change this in Unity Editor

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();          // Establish connection   
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);                 //  a & d moves left and right

        float xMovement = Input.GetAxis("Horizontal");
        if 
            (xMovement > 0 ) 
        { _spriteRenderer.flipX = true;}

        else if
            (xMovement < 0 ) 
        { _spriteRenderer.flipX = false;}


    }
}
