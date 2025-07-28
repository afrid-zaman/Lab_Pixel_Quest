using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;
    private int _coinCounter = 0;
    private int coinsInLevel = 0;
    private int _health = 3;
    private int maxHealth = 3;
    private PlayerUIController playerUIController;
    // Start is called before the first frame update
    void Start()
    {
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
        playerUIController = GetComponent<PlayerUIController>();
        playerUIController.StartUI();
        playerUIController.UpdateText(_coinCounter + "/" + coinsInLevel);
        playerUIController.UpdateHeart(_health,maxHealth);
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
                    playerUIController.UpdateHeart(_health, maxHealth);
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
                    playerUIController.UpdateText(_coinCounter + "/" + coinsInLevel);
                    break;
                }

            case "Health":
                {
                    if (_health < 3)
                    {
                        _health++;
                        playerUIController.UpdateHeart(_health, maxHealth);
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
