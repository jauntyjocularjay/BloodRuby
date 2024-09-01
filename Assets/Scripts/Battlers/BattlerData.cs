using System;
using UnityEngine;

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
    // public Genus genus;
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

}

/* [CreateAssetMenu(menuName = "ScriptableObjects/PlayerBattler")]
// public class PlayerBattler : BattlerData
// {
//     public int curXP;
//     public int xpToNextLevel;
//     public string alias;
// }
*/

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
    Genus genus = Genus.Bat;

    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Beholder")]
public class Beholder: BattlerData
{
    Genus genus = Genus.Beholder;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Bird")]
public class Bird: BattlerData
{
    Genus genus = Genus.Bird;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Boar")]
public class Boar: BattlerData
{
    Genus genus = Genus.Boar;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Cactus")]
public class Cactus: BattlerData
{
    Genus genus = Genus.Cactus;

    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Ceph")]
public class Ceph: BattlerData
{
    Genus genus = Genus.Ceph;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Crab")]
public class Crab: BattlerData
{
    Genus genus = Genus.Crab;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Demon")]
public class Demon: BattlerData
{
    Genus genus = Genus.Demon;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Djinn")]
public class Djinn: BattlerData
{
    Genus genus = Genus.Djinn;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Dragon")]
public class Dragon: BattlerData
{
    Genus genus = Genus.Dragon;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Eagle")]
public class Eagle: BattlerData
{
    Genus genus = Genus.Eagle;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Elemental")]
public class Elemental: BattlerData
{
    Genus genus = Genus.Elemental;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Elk")]
public class Elk: BattlerData
{
    Genus genus = Genus.Elk;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Frog")]
public class Frog: BattlerData
{
    Genus genus = Genus.Frog;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Fungus")]
public class Fungus: BattlerData
{
    Genus genus = Genus.Fungus;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Gator")]
public class Gator: BattlerData
{
    Genus genus = Genus.Gator;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Ghost")]
public class Ghost: BattlerData
{
    Genus genus = Genus.Ghost;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Giant")]
public class Giant: BattlerData
{
    Genus genus = Genus.Giant;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Golem")]
public class Golem: BattlerData
{
    Genus genus = Genus.Golem;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Grater")]
public class Grater: BattlerData
{
    Genus genus = Genus.Grater;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Head")]
public class Head: BattlerData
{
    Genus genus = Genus.Head;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Hornet")]
public class Hornet: BattlerData
{
    Genus genus = Genus.Hornet;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Jacko")]
public class Jacko: BattlerData
{
    Genus genus = Genus.Jacko;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Jelly")]
public class Jelly: BattlerData
{
    Genus genus = Genus.Jelly;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Keebler")]
public class Keebler: BattlerData
{
    Genus genus = Genus.Keebler;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Knight")]
public class Knight: BattlerData
{
    Genus genus = Genus.Knight;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Kobold")]
public class Kobold: BattlerData
{
    Genus genus = Genus.Kobold;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Lich")]
public class Lich: BattlerData
{
    Genus genus = Genus.Lich;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/LizardMan")]
public class LizardMan: BattlerData
{
    Genus genus = Genus.LizardMan;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mage")]
public class Mage: BattlerData
{
    Genus genus = Genus.Mage;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mimic")]
public class Mimic: BattlerData
{
    Genus genus = Genus.Mimic;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Minotaur")]
public class Minotaur: BattlerData
{
    Genus genus = Genus.Minotaur;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mouse")]
public class Mouse: BattlerData
{
    Genus genus = Genus.Mouse;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mushroom")]
public class Mushroom: BattlerData
{
    Genus genus = Genus.Mushroom;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Octo")]
public class Octo: BattlerData
{
    Genus genus = Genus.Octo;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Orb")]
public class Orb: BattlerData
{
    Genus genus = Genus.Orb;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Phoenix")]
public class Phoenix: BattlerData
{
    Genus genus = Genus.Phoenix;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Plantee")]
public class Plantee: BattlerData
{
    Genus genus = Genus.Plantee;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Poltergeist")]
public class Poltergeist: BattlerData
{
    Genus genus = Genus.Poltergeist;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Raptor")]
public class Raptor: BattlerData
{
    Genus genus = Genus.Raptor;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Scorpion")]
public class Scorpion: BattlerData
{
    Genus genus = Genus.Scorpion;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Skeleton")]
public class Skeleton: BattlerData
{
    Genus genus = Genus.Skeleton;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Slime")]
public class Slime: BattlerData
{
    Genus genus = Genus.Slime;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Snail")]
public class Snail: BattlerData
{
    Genus genus = Genus.Snail;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Snake")]
public class Snake: BattlerData
{
    Genus genus = Genus.Snake;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Spider")]
public class Spider: BattlerData
{
    Genus genus = Genus.Spider;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/SpiderLady")]
public class SpiderLady: BattlerData
{
    Genus genus = Genus.SpiderLady;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Succubus")]
public class Succubus: BattlerData
{
    Genus genus = Genus.Succubus;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Toad")]
public class Toad: BattlerData
{
    Genus genus = Genus.Toad;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Treant")]
public class Treant: BattlerData
{
    Genus genus = Genus.Treant;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Turtle")]
public class Turtle: BattlerData
{
    Genus genus = Genus.Turtle;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/WhipWeed")]
public class WhipWeed: BattlerData
{
    Genus genus = Genus.WhipWeed;
    private void Awake()
    {
        primaryAttribute = Attribute.Agility;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Wolf")]
public class Wolf: BattlerData
{
    Genus genus = Genus.Wolf;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Worm")]
public class Worm: BattlerData
{
    Genus genus = Genus.Worm;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Wraith")]
public class Wraith: BattlerData
{
    Genus genus = Genus.Wraith;
    private void Awake()
    {
        primaryAttribute = Attribute.Wisdom;
    }

}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Zombie")]
public class Zombie: BattlerData
{
    Genus genus = Genus.Zombie;
    private void Awake()
    {
        primaryAttribute = Attribute.Strength;
    }

}



