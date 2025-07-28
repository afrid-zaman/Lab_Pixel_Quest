using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string nextLevel;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
