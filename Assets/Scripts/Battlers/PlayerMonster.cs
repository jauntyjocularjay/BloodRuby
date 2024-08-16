using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMonster : PlayerBattler
{
    public PlayerMonster(PlayerMonster battler)
    {
        maxHP = battler.maxHP;
        curHP = battler.curHP;
        primaryAttribute = battler.primaryAttribute;
        agility = battler.agility;
        strength = battler.strength;
        wisdom = battler.wisdom;
        genus = battler.genus;
        healthBarFill = battler.healthBarFill;
        curXP = battler.curXP;
        xpToNextLevel = battler.xpToNextLevel;
        level = battler.level;
    }



    public void Buff(int amount, Attribute attribute)
    {

    }

    public void Debuff(int amount)
    {

    }

    public void TakeDamage()
    {

    }

}
