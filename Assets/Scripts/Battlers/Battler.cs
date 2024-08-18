using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Battler : MonoBehaviour
{
    public int maxHP;
    public int curHP;
    public int level;
    public Attribute primaryAttribute;
    public int agility;
    public int strength;
    public int wisdom;
    public Genus genus;
    public Image portrait;
    public Image healthBarFill;

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

    public void Attack(int amount)
    {
        
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
