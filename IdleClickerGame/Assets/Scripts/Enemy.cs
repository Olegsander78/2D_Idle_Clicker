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
    public Animation Anim;

    public void Damage()
    {
        CurrentHealth--;
        HealthBarFill.fillAmount = (float)CurrentHealth / (float)MaxHealth;

        Anim.Stop();
        Anim.Play();

        if (CurrentHealth <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        GameManager.Instance.AddGold(GoldToGive);
        EnemyManager.Instance.DefeatEnemy(gameObject);
    }
}
