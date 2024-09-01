using System;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Empty")]
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

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Bat")]
public class Bat: BattlerData
{

    private void Awake()
    {
        genus = Genus.Bat;
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Beholder")]
public class Beholder: BattlerData
{
    private void Awake()
    {
        genus = Genus.Beholder;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Bird")]
public class Bird: BattlerData
{
    private void Awake()
    {
        genus = Genus.Bird;
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Boar")]
public class Boar: BattlerData
{
    private void Awake()
    {
        genus = Genus.Boar;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Cactus")]
public class Cactus : BattlerData
{
    private void Awake()
    {
        genus = Genus.Cactus;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Ceph")]
public class Ceph : BattlerData
{
    private void Awake()
    {
        genus = Genus.Ceph;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Crab")]
public class Crab : BattlerData
{
    private void Awake()
    {
        genus = Genus.Crab;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Demon")]
public class Demon : BattlerData
{
    private void Awake()
    {
        genus = Genus.Demon;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Djinn")]
public class Djinn : BattlerData
{
    private void Awake()
    {
        genus = Genus.Djinn;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Dragon")]
public class Dragon : BattlerData
{
    private void Awake()
    {
        genus = Genus.Dragon;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Eagle")]
public class Eagle : BattlerData
{
    private void Awake()
    {
        genus = Genus.Eagle;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Elemental")]
public class Elemental : BattlerData
{
    private void Awake()
    {
        genus = Genus.Elemental;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Elk")]
public class Elk : BattlerData
{
    private void Awake()
    {
        genus = Genus.Elk;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Frog")]
public class Frog : BattlerData
{
    private void Awake()
    {
        genus = Genus.Frog;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Fungus")]
public class Fungus : BattlerData
{
    private void Awake()
    {
        genus = Genus.Fungus;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Gator")]
public class Gator : BattlerData
{
    private void Awake()
    {
        genus = Genus.Gator;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Ghost")]
public class Ghost : BattlerData
{
    private void Awake()
    {
        genus = Genus.Ghost;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Giant")]
public class Giant : BattlerData
{
    private void Awake()
    {
        genus = Genus.Giant;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Golem")]
public class Golem : BattlerData
{
    private void Awake()
    {
        genus = Genus.Golem;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Grater")]
public class Grater : BattlerData
{
    private void Awake()
    {
        genus = Genus.Grater;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Head")]
public class Head : BattlerData
{
    private void Awake()
    {
        genus = Genus.Head;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Hornet")]
public class Hornet : BattlerData
{
    private void Awake()
    {
        genus = Genus.Hornet;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Jacko")]
public class Jacko : BattlerData
{
    private void Awake()
    {
        genus = Genus.Jacko;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Jelly")]
public class Jelly : BattlerData
{
    private void Awake()
    {
        genus = Genus.Jelly;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Keebler")]
public class Keebler : BattlerData
{
    private void Awake()
    {
        genus = Genus.Keebler;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Knight")]
public class Knight : BattlerData
{
    private void Awake()
    {
        genus = Genus.Knight;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Kobold")]
public class Kobold : BattlerData
{
    private void Awake()
    {
        genus = Genus.Kobold;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Lich")]
public class Lich : BattlerData
{
    private void Awake()
    {
        genus = Genus.Lich;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/LizardMan")]
public class LizardMan : BattlerData
{
    private void Awake()
    {
        genus = Genus.LizardMan;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mage")]
public class Mage : BattlerData
{
    private void Awake()
    {
        genus = Genus.Mage;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mimic")]
public class Mimic : BattlerData
{
    private void Awake()
    {
        genus = Genus.Mimic;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Minotaur")]
public class Minotaur : BattlerData
{
    private void Awake()
    {
        genus = Genus.Minotaur;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mouse")]
public class Mouse : BattlerData
{
    private void Awake()
    {
        genus = Genus.Mouse;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mushroom")]
public class Mushroom : BattlerData
{
    private void Awake()
    {
        genus = Genus.Mushroom;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Octo")]
public class Octo : BattlerData
{
    private void Awake()
    {
        genus = Genus.Octo;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Orb")]
public class Orb : BattlerData
{
    private void Awake()
    {
        genus = Genus.Orb;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Phoenix")]
public class Phoenix : BattlerData
{
    private void Awake()
    {
        genus = Genus.Phoenix;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Plantee")]
public class Plantee : BattlerData
{
    private void Awake()
    {
        genus = Genus.Plantee;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Poltergeist")]
public class Poltergeist : BattlerData
{
    private void Awake()
    {
        genus = Genus.Poltergeist;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Raptor")]
public class Raptor : BattlerData
{
    private void Awake()
    {
        genus = Genus.Raptor;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Scorpion")]
public class Scorpion : BattlerData
{
    private void Awake()
    {
        genus = Genus.Scorpion;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Skeleton")]
public class Skeleton : BattlerData
{
    private void Awake()
    {
        genus = Genus.Skeleton;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Slime")]
public class Slime : BattlerData
{
    private void Awake()
    {
        genus = Genus.Slime;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Snail")]
public class Snail : BattlerData
{
    private void Awake()
    {
        genus = Genus.Snail;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Snake")]
public class Snake : BattlerData
{
    private void Awake()
    {
        genus = Genus.Snake;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Spider")]
public class Spider : BattlerData
{
    private void Awake()
    {
        genus = Genus.Spider;
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/SpiderLady")]
public class SpiderLady : BattlerData
{
    private void Awake()
    {
        genus = Genus.SpiderLady;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Succubus")]
public class Succubus : BattlerData
{
    private void Awake()
    {
        genus = Genus.Succubus;
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Toad")]
public class Toad : BattlerData
{
    private void Awake()
    {
        genus = Genus.Toad;
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Treant")]
public class Treant: BattlerData
{
    private void Awake()
    {
        genus = Genus.Treant;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Turtle")]
public class Turtle: BattlerData
{
    private void Awake()
    {
        genus = Genus.Turtle;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/WhipWeed")]
public class WhipWeed: BattlerData
{
    private void Awake()
    {
        genus = Genus.WhipWeed;
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Wolf")]
public class Wolf: BattlerData
{
    private void Awake()
    {
        genus = Genus.Wolf;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Worm")]
public class Worm: BattlerData
{
    private void Awake()
    {
        genus = Genus.Worm;
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Wraith")]
public class Wraith: BattlerData
{
    private void Awake()
    {
        genus = Genus.Wraith;
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Zombie")]
public class Zombie: BattlerData
{
    private void Awake()
    {
        genus = Genus.Zombie;
        primaryAttribute = Attribute.Strength;
    }

}



