using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Capsule 
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;

    //Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;


    // Components
    private Rigidbody2D _rigidbody2D;

    // Forces 
    public float jumpforce = 10;

    // Sets gravity vector and connects components

    // Start is called before the first frame update



    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }






    // Update is called once per frame
    void Update()
    {
        // checks if player is trying to jump /can jump.

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpforce);    
        }
    }
}
