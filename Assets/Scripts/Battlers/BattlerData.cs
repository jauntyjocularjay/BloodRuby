using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/BattlerData")]
public class BattlerData : ScriptableObject
{
    public int maxHP;
    public int level;
    public Attribute primaryAttribute;
    public int agility; // Min: 0, Max: 36
    public int strength; // Min: 0, Max: 36
    public int wisdom; // Min: 0, Max: 36
    public Genus genus;
    public Sprite portrait;
    public SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        if(
            agility > 36 || 
            agility <= 0 || 
            strength > 36 || 
            strength <= 0 || 
            wisdom > 36 || 
            wisdom <= 0
        )
        {
            throw new InvalidAttributeIntegerException();
        }
    }

    private int GetPrimaryAttribute()
    {
        if(primaryAttribute == Attribute.Agility)
        {
            return agility;
        }
        else if(primaryAttribute == Attribute.Strength)
        {
            return strength;
        }
        else //(primaryAttribute == Attribute.Wisdom)
        {
            return wisdom;
        }
    }

    private int GetAttribute(Attribute attr)
    {
        if(attr == Attribute.Agility)
        {
            return agility;
        }
        else if (attr == Attribute.Strength)
        {
            return strength;
        }
        else if (attr == Attribute.Wisdom)
        {
            return wisdom;
        }
        else // throw new InvalidEnumArgumentException
        {
            throw new InvalidEnumArgumentException($"Defender does not have the attribute: {attr}"); 
        }
    }

    public int AttackDamage()
    {
        double damage;
        double attribute = (double) GetPrimaryAttribute() / 6;
        double lvl = level;

        damage = attribute * lvl * Math.Log(attribute * lvl);

        return (int) damage;
    }

    public int Defend(Attribute enemyPrimaryAttribute, int EnemyAttackDamage)
    {
        double result;
        double incomingDamage = EnemyAttackDamage;
        double lvl = level;

        result = 
            incomingDamage * (
                (double) 36 - GetAttribute(enemyPrimaryAttribute) / 36
            );

        return (int) result;
    }

    private void Defeat()
    {
        Debug.Log("Defeated");
    }

}

public class PlayerBattler : BattlerData
{
    public int curXP;
    public int xpToNextLevel;
    public string alias;

}
public class InvalidAttributeIntegerException : Exception
{
    public InvalidAttributeIntegerException() : 
        base("Attribute must be an integer [1-36] inclusive")
    {}
}
public enum Genus {
    Bat, 
    Beholder, 
    Mushroom, 
    Bird, 
    Blick, 
    Boar, 
    Cactus, 
    Ceph,
    Crab, 
    Demon,
    Djinn, 
    Female, 
    Eagle, 
    Elemental, 
    Elk,
    Fungus,
    Skull, 
    Frog, 
    Fungusaur, 
    Gator, 
    Ghost, 
    Giant, 
    Golem, 
    Grater, 
    Head, 
    Hornet, 
    Insect, 
    Golden, 
    Jacko, 
    Jelly, 
    Floating, 
    Keebler, 
    Knight, 
    Kobold, 
    Lich, 
    LizardMan, 
    Mage,
    Mimic,
    Minotaur, 
    Mouse, 
    Octo, 
    Orb,
    Phoenix, 
    Plantee, 
    Poltergeist,
    Raptor, 
    Scorpion, 
    Skeleton,
    Slime,
    Snail,
    Snake,
    SpiderLady,
    Spider, 
    Statue, 
    Succubus,
    Toad, 
    Treant, 
    Turtle, 
    WhipWeed,
    Wolf,
    Worm, 
    Wraith, 
    Zombie
}

public enum Attribute {
    Agility,
    Strength,
    Wisdom
}
