using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;                        // Reference variable
    public int speed = 5;                          // You can change this in Unity Editor

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();          // Establish connection
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }




}

