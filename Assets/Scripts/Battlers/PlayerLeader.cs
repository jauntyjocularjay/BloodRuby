using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeader : PlayerBattler
{
    public PlayerLeader(PlayerLeader battler)
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
        alias = battler.alias;
    }

    public void Guard()
    {

    }

    
}
