using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    public int maxHP;
    public int curHP;
    public int strength;
    public int wisdom;
    public int agility;
    public Image healthBarFill;

    public void Damage(int amount)
    {
        curHP -= amount;
        healthBarFill.fillAmount = 
            (float) curHP / (float) maxHP;

        if(curHP <= 0)
        {
            Defeat();
        }
    }

    public void Damage()
    {
        Damage(1);
    }

    private void Defeat()
    {
        Debug.Log("Defeated");
    }
}

