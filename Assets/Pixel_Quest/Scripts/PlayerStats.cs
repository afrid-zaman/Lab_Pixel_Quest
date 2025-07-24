using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;
    private int _coinCounter = 0;
    private int _health = 3;
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
                    _health--;
                    if (_health <= 0)
                    {
                        string thislvl = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislvl);
                    }
                    else
                    { 
                        transform.position = respawnPoint.position;
                    }
                    
                    break;
                }
            case "Coin":
                {
                    _coinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "Health":
                {
                    if (_health < 3)
                    {
                        _health++;
                        Destroy(collision.gameObject);
                    }
                    break;  
                }

            case "Respawn":
                { 
                    respawnPoint.position = collision.transform.Find("point").position;
                    break;
                }

            case "Finish":
                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;

                }
        }
    }
}
