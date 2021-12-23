using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int CurrentHealth;
    public int MaxHealth;
    public int GoldToGive;
    public Image HealthBarFill;

    public void Damage()
    {
        CurrentHealth--;
        HealthBarFill.fillAmount = (float)CurrentHealth / (float)MaxHealth;

        if (CurrentHealth <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        Debug.Log("Defeated");
    }
}
