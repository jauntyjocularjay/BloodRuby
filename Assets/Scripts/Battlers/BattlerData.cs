using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler")]
public class BattlerData : ScriptableObject
{
    public int maxHP;
    public FractionScale HP;
    private int level;
    public Attribute primaryAttribute;
    public int agi;
    public int str;
    public int wis;
    private readonly AttributeScale agility = new(0);
    private readonly AttributeScale strength = new(0);
    private readonly AttributeScale wisdom = new(0);
    public Genus genus;
    public Sprite portrait;
    
    private void Start()
    {
        agility.SetNumerator(agi);
        strength.SetNumerator(str);
        wisdom.SetNumerator(wis);
        HP = new (maxHP);
        level = 1;
    }
    private void LevelUp()
    {
        level++;
    }
    private int GetAttribute(Attribute attr)
    {
        return attr switch
        {
            Attribute.Agility => agility.Get(),
            Attribute.Strength => strength.Get(),
            Attribute.Wisdom => wisdom.Get(),
            _ => throw new InvalidAttributeException()
        };
    }
    private int GetPrimaryAttribute()
    {
        return GetAttribute(primaryAttribute);    
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
[CreateAssetMenu(menuName = "ScriptableObjects/PlayerBattler")]
public class PlayerBattler : BattlerData
{
    public int curXP;
    public int xpToNextLevel;
    public string alias;
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
public class InvalidAttributeException : Exception
{
    public InvalidAttributeException() : base() {}
    public InvalidAttributeException(Attribute attr) :
        base($"The attribute {attr} is invalid.") {}
}
public class AttributeScale : FractionScale
{
    public AttributeScale(int n) :
        base(n, 36){}

}
