using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battler : MonoBehaviour
{
    public int maxHP;
    public int curHP;
    public Attribute primaryAttribute;
    public int agility;
    public int strength;
    public int wisdom;
    public Genus genus;
    public Image healthBarFill;

    // public Battler(Battler battler)
    // {
    //     maxHP = battler.maxHP;
    //     curHP = battler.curHP;
    //     primaryAttribute = battler.primaryAttribute;
    //     agility = battler.agility;
    //     strength = battler.strength;
    //     wisdom = battler.wisdom;
    //     genus = battler.genus;
    //     healthBarFill = battler.healthBarFill;
    // }

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

    public void Attack(int amount)
    {
        
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

public class PlayerBattler : Battler
{
    public int curXP;
    public int xpToNextLevel;
    public int level;
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
    Crab, 
    Demon,
    Djinn, 
    Female, 
    Eagle, 
    Elemental, 
    Elk, 
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
