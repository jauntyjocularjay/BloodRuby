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
    public int agi;
    public int str;
    public int wis;
    private FractionScale agility = new (0,36); // Min: 0, Max: 36
    private FractionScale strength = new (0,36); // Min: 0, Max: 36
    private FractionScale wisdom = new (0,36); // Min: 0, Max: 36
    public Genus genus;
    public Sprite portrait;
    
    private void Start()
    {
        if(
            agility.GetNumerator() > 36 || 
            agility.GetNumerator() < 0 || 
            strength.GetNumerator() > 36 || 
            strength.GetNumerator() < 0 || 
            wisdom.GetNumerator() > 36 || 
            wisdom.GetNumerator() < 0
        )
        {
            throw new InvalidAttributeIntegerException();
        }

        agility.SetNumerator(agi);

    }

    private int GetPrimaryAttribute()
    {
        if(primaryAttribute == Attribute.Agility)
        {
            return agility.GetNumerator();
        }
        else if(primaryAttribute == Attribute.Strength)
        {
            return strength.GetNumerator();
        }
        else //(primaryAttribute == Attribute.Wisdom)
        {
            return wisdom.GetNumerator();
        }
    }

    private int GetAttribute(Attribute attr)
    {
        if(attr == Attribute.Agility)
        {
            return agility.GetNumerator();
        }
        else if (attr == Attribute.Strength)
        {
            return strength.GetNumerator();
        }
        else if (attr == Attribute.Wisdom)
        {
            return wisdom.GetNumerator();
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
        base("Attribute must be an integer [0-36] inclusive"){}
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
