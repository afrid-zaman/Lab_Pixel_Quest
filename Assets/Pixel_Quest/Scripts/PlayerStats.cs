using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public string nextLvl = "1";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislvl = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislvl);
                    break;

                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLvl);
                    break;

                }
        }
    }
}
