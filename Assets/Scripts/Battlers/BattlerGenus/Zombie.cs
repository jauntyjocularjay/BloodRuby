using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Zombie")]
public class Zombie: BattlerData
{
    private void Awake()
    {
        genus = Genus.Zombie;
        primaryAttribute = Attribute.Strength;
    }

}