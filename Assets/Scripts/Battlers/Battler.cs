using System;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Empty")]
public class BattlerData : ScriptableObject
{
    // public Script script;
    public string alias;
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
    
    public void StartData()
    {
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
    public Genus GetGenus()
    {
        return genus;
    }
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
    Dragon,
    Djinn,
    Eagle, 
    Elemental, 
    Elk,
    Fungus,
    Skull, 
    Frog, 
    Gator,
    Ghost, 
    Giant, 
    Golem,
    Grater, 
    Head, 
    Hornet,
    Hunter,
    Jacko, 
    Jelly, 
    Keebler, 
    Knight, 
    Kobold, 
    Lich, 
    LizardMan, 
    Mage,
    Man,
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







[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/LizardMan")]
public class LizardMan : BattlerData
{
    private void Awake()
    {
        genus = Genus.LizardMan;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Minotaur")]
public class Minotaur : BattlerData
{
    private void Awake()
    {
        genus = Genus.Minotaur;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Mouse")]
public class Mouse : BattlerData
{
    private void Awake()
    {
        genus = Genus.Mouse;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Phoenix")]
public class Phoenix : BattlerData
{
    private void Awake()
    {
        genus = Genus.Phoenix;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Plantee")]
public class Plantee : BattlerData
{
    private void Awake()
    {
        genus = Genus.Plantee;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Scorpion")]
public class Scorpion : BattlerData
{
    private void Awake()
    {
        genus = Genus.Scorpion;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Skeleton")]
public class Skeleton : BattlerData
{
    private void Awake()
    {
        genus = Genus.Skeleton;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Snail")]
public class Snail : BattlerData
{
    private void Awake()
    {
        genus = Genus.Snail;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/SpiderLady")]
public class SpiderLady : BattlerData
{
    private void Awake()
    {
        genus = Genus.SpiderLady;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Toad")]
public class Toad : BattlerData
{
    private void Awake()
    {
        genus = Genus.Toad;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Treant")]
public class Treant: BattlerData
{
    private void Awake()
    {
        genus = Genus.Treant;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Turtle")]
public class Turtle: BattlerData
{
    private void Awake()
    {
        genus = Genus.Turtle;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/WhipWeed")]
public class WhipWeed: BattlerData
{
    private void Awake()
    {
        genus = Genus.WhipWeed;
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Wolf")]
public class Wolf: BattlerData
{
    private void Awake()
    {
        genus = Genus.Wolf;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Worm")]
public class Worm: BattlerData
{
    private void Awake()
    {
        genus = Genus.Worm;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Wraith")]
public class Wraith: BattlerData
{
    private void Awake()
    {
        genus = Genus.Wraith;
        primaryAttribute = Attribute.Wisdom;
    }

}



