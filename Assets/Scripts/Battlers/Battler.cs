using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battler : MonoBehaviour
{
    public int maxHP;
    public int curHP;
    public PrimaryAttribute primaryAttribute;
    public int strength;
    public int curStrength;
    public int wisdom;
    public int curWisdom;
    public int agility;
    public int curAgility;
    public Genus genus;
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

public enum PrimaryAttribute {
    Agility,
    Strength,
    Wisdom
}
