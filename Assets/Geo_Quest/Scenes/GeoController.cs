using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string introduction = "Hello!";
    int ver01 = 3;
        // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Wrold");
        string introduction2 = "Wrold..";
        Debug.Log(introduction + introduction2);
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(ver01);
        ver01++;
    }
}
