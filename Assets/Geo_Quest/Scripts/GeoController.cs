using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    public float changingVelocity;
    private Rigidbody2D rb;
    string varOne = "Hello";
    int var = 3;
        // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");
        string varTwo = "World";
        Debug.Log("varOne + vartwo");
    }

    // Update is called once per frame
    void Update()
    {
        float inputxaxis = Input.GetAxis("Horizontal");
        Debug.Log(inputxaxis);
        rb.velocity = new Vector2(inputxaxis * changingVelocity, rb.velocity.y);

        
    }
}
