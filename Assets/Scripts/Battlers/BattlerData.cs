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
public class BatBattler : BattlerData
{
    Genus genus = Genus.Bat;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Beholder")]
public class BeholderBattler : BattlerData
{
    Genus genus = Genus.Beholder;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mushroom")]
public class MushroomBattler : BattlerData
{
    Genus genus = Genus.Mushroom;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Bird")]
public class BirdBattler : BattlerData
{
    Genus genus = Genus.Bird;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Blick")]
public class BlickBattler : BattlerData
{
    Genus genus = Genus.Blick;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Boar")]
public class BoarBattler : BattlerData
{
    Genus genus = Genus.Boar;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Cactus")]
public class CactusBattler : BattlerData
{
    Genus genus = Genus.Cactus;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Ceph")]
public class CephBattler : BattlerData
{
    Genus genus = Genus.Ceph;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Crab")]
public class CrabBattler : BattlerData
{
    Genus genus = Genus.Crab;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Demon")]
public class DemonBattler : BattlerData
{
    Genus genus = Genus.Demon;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Dragon")]
public class DragonBattler : BattlerData
{
    Genus genus = Genus.Dragon;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Djinn")]
public class DjinnBattler : BattlerData
{
    Genus genus = Genus.Djinn;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Eagle")]
public class EagleBattler : BattlerData
{
    Genus genus = Genus.Eagle;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Elemental")]
public class ElementalBattler : BattlerData
{
    Genus genus = Genus.Elemental;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Elk")]
public class ElkBattler : BattlerData
{
    Genus genus = Genus.Elk;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Fungus")]
public class FungusBattler : BattlerData
{
    Genus genus = Genus.Fungus;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Skull")]
public class SkullBattler : BattlerData
{
    Genus genus = Genus.Skull;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Frog")]
public class FrogBattler : BattlerData
{
    Genus genus = Genus.Frog;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Gator")]
public class GatorBattler : BattlerData
{
    Genus genus = Genus.Gator;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Ghost")]
public class GhostBattler : BattlerData
{
    Genus genus = Genus.Ghost;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Giant")]
public class GiantBattler : BattlerData
{
    Genus genus = Genus.Giant;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Golem")]
public class GolemBattler : BattlerData
{
    Genus genus = Genus.Golem;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Grater")]
public class GraterBattler : BattlerData
{
    Genus genus = Genus.Grater;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Head")]
public class HeadBattler : BattlerData
{
    Genus genus = Genus.Head;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Hornet")]
public class HornetBattler : BattlerData
{
    Genus genus = Genus.Hornet;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Insect")]
public class InsectBattler : BattlerData
{
    Genus genus = Genus.Insect;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Golden")]
public class GoldenBattler : BattlerData
{
    Genus genus = Genus.Golden;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Jacko")]
public class JackoBattler : BattlerData
{
    Genus genus = Genus.Jacko;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Jelly")]
public class JellyBattler : BattlerData
{
    Genus genus = Genus.Jelly;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Floating")]
public class FloatingBattler : BattlerData
{
    Genus genus = Genus.Floating;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Keebler")]
public class KeeblerBattler : BattlerData
{
    Genus genus = Genus.Keebler;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Knight")]
public class KnightBattler : BattlerData
{
    Genus genus = Genus.Knight;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Kobold")]
public class KoboldBattler : BattlerData
{
    Genus genus = Genus.Kobold;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Lich")]
public class LichBattler : BattlerData
{
    Genus genus = Genus.Lich;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/LizardMan")]
public class LizardManBattler : BattlerData
{
    Genus genus = Genus.LizardMan;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mage")]
public class MageBattler : BattlerData
{
    Genus genus = Genus.Mage;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mimic")]
public class MimicBattler : BattlerData
{
    Genus genus = Genus.Mimic;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Minotaur")]
public class MinotaurBattler : BattlerData
{
    Genus genus = Genus.Minotaur;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Mouse")]
public class MouseBattler : BattlerData
{
    Genus genus = Genus.Mouse;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Octo")]
public class OctoBattler : BattlerData
{
    Genus genus = Genus.Octo;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Orb")]
public class OrbBattler : BattlerData
{
    Genus genus = Genus.Orb;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Phoenix")]
public class PhoenixBattler : BattlerData
{
    Genus genus = Genus.Phoenix;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Plantee")]
public class PlanteeBattler : BattlerData
{
    Genus genus = Genus.Plantee;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Poltergeist")]
public class PoltergeistBattler : BattlerData
{
    Genus genus = Genus.Poltergeist;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Raptor")]
public class RaptorBattler : BattlerData
{
    Genus genus = Genus.Raptor;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Scorpion")]
public class ScorpionBattler : BattlerData
{
    Genus genus = Genus.Scorpion;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Skeleton")]
public class SkeletonBattler : BattlerData
{
    Genus genus = Genus.Skeleton;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Slime")]
public class SlimeBattler : BattlerData
{
    Genus genus = Genus.Slime;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Snail")]
public class SnailBattler : BattlerData
{
    Genus genus = Genus.Snail;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Snake")]
public class SnakeBattler : BattlerData
{
    Genus genus = Genus.Snake;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/SpiderLady")]
public class SpiderLadyBattler : BattlerData
{
    Genus genus = Genus.SpiderLady;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Spider")]
public class SpiderBattler : BattlerData
{
    Genus genus = Genus.Spider;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Statue")]
public class StatueBattler : BattlerData
{
    Genus genus = Genus.Statue;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Succubus")]
public class SuccubusBattler : BattlerData
{
    Genus genus = Genus.Succubus;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Toad")]
public class ToadBattler : BattlerData
{
    Genus genus = Genus.Toad;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Treant")]
public class TreantBattler : BattlerData
{
    Genus genus = Genus.Treant;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Turtle")]
public class TurtleBattler : BattlerData
{
    Genus genus = Genus.Turtle;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/WhipWeed")]
public class WhipWeedBattler : BattlerData
{
    Genus genus = Genus.WhipWeed;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Wolf")]
public class WolfBattler : BattlerData
{
    Genus genus = Genus.Wolf;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Worm")]
public class WormBattler : BattlerData
{
    Genus genus = Genus.Worm;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Wraith")]
public class WraithBattler : BattlerData
{
    Genus genus = Genus.Wraith;
}

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Zombie")]
public class ZombieBattler : BattlerData
{
    Genus genus = Genus.Zombie;
}




