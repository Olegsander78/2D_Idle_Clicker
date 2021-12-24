using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public int Gold;
    public TextMeshProUGUI GoldText;

    public Sprite[] Backgrounds;
    private int _curBackground;
    private int _enemiesUntilBackgroundChange;
    public Image BackgroundImage;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
        _enemiesUntilBackgroundChange = 5;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        GoldText.text = "Gold: " + Gold.ToString();
    }
    
    public void TakeGold(int amount)
    {
        Gold -= amount;
        GoldText.text = "Gold: " + Gold.ToString();
    }

    public void BackgroundCheck()
    {
        _enemiesUntilBackgroundChange--;

        if (_enemiesUntilBackgroundChange == 0)
        {
            _enemiesUntilBackgroundChange = 5;

            _curBackground++;

            if (_curBackground == Backgrounds.Length)
            {
                _curBackground = 0;
            }
            BackgroundImage.sprite = Backgrounds[_curBackground];

        }
    }
}
