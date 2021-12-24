using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickerManager : MonoBehaviour
{
    public List<float> AutoClickerLastTime = new List<float>();
    public int AutoClickerPrice;
    public TextMeshProUGUI QuantityText;


    private void Update()
    {
        for (int i = 0; i < AutoClickerLastTime.Count; i++)
        {
            if (Time.time - AutoClickerLastTime[i] >= 1f)
            {
                AutoClickerLastTime[i] = Time.time;
                EnemyManager.Instance.CurrentEnemy.Damage();
            }
        }
    }

    public void OnBuyAutoClicker()
    {
        if(GameManager.Instance.Gold >= AutoClickerPrice)
        {
            GameManager.Instance.TakeGold(AutoClickerPrice);
            AutoClickerLastTime.Add(Time.time);
            QuantityText.text = "x " + AutoClickerLastTime.Count.ToString();
        }
    }
}
