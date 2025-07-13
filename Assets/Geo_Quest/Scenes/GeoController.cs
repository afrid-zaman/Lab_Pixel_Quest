using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string varOne = "Hello";
    int var = 3;
        // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string varTwo = "World";
        Debug.Log("varOne + vartwo");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        var++;
        transform.position += new Vector3(0.005f, 0, 0);
    }
}
