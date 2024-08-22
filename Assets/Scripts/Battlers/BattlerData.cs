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
    public int agility;
    public int strength;
    public int wisdom;
    public Genus genus;
    public Sprite portrait;
    
    private void Start()
    {
        int a = UnityEngine.Random.Range(0,3);
    }

    public int AttackTotal()
    {
        int primaryAttribute =  GetPrimaryAttribute();        
        return primaryAttribute * level / (primaryAttribute + level);
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
        else if(primaryAttribute == Attribute.Wisdom)
        {
            return wisdom;
        }
        else
        {
            throw new InvalidEnumArgumentException("The selected attribute is not an option.");
        }

    }

    // public void Damage(int amount)
    // {
    //     curHP -= amount;
    //     spot.healthBarFill.fillAmount = 
    //         (float) curHP / (float) maxHP;

    //     if(curHP <= 0)
    //     {
    //         Defeat();
    //     }
    // }
    
    // public void Damage()
    // {
    //     Damage(1);
    // }

    public int Attack()
    {
        int damage;
        int attribute = GetPrimaryAttribute();

        damage = (int) Math.Pow((double) attribute, (double) level) / level;

        return damage;
    }

    public void Defend()
    {

    }

    private void Defeat()
    {
        Debug.Log("Defeated");
    }

    // private void SetSpriteRenderer()
    // {
    //     spriteRenderer.sprite = portrait;
    // }
}

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
