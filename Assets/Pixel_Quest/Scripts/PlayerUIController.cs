using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUIController : MonoBehaviour
{
    private Image _heartImage;
    private TextMeshProUGUI _coins;

    // Start is called before the first frame update
    public void StartUI()
    {
        _heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        _coins = GameObject.Find("CoinText").GetComponent <TextMeshProUGUI>();
    }
    public void UpdateHeart(float currentHealth, float maxHealth)
    {
        _heartImage.fillAmount = currentHealth/maxHealth;
    }

    public void UpdateText(string newText)
    {
        _coins.text = newText;
    }


}
