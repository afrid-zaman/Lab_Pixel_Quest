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
<<<<<<< Updated upstream:Assets/Geo_Quest/Scripts/GeoController.cs
        float inputxaxis = Input.GetAxis("Horizontal");
        Debug.Log(inputxaxis);
        rb.velocity = new Vector2(inputxaxis * changingVelocity, rb.velocity.y);

        
=======
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);       /*/press W = OBJECT moves 01 unit up./*/
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);      //press S = object moves 01 unit down
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            transform.position += new Vector3(-1, 0, 0); 
        }
>>>>>>> Stashed changes:Assets/Geo_Quest/Scenes/GeoController.cs
    }
}
