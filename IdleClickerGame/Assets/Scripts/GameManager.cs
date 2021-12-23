using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Gold;
    public TextMeshProUGUI GoldText;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        GoldText.text = "Gold: " + Gold.ToString();
    }

}
