using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = (Color.red); // Change color to red when 1 is pressed
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = (Color.green); // Change color to green when 2 is pressed
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = (Color.blue); // Change color to blue when 3 is pressed
        }

    }
}
