using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Cactus")]
public class Cactus : BattlerData
{
    private void Awake()
    {
        genus = Genus.Cactus;
        primaryAttribute = Attribute.Strength;
    }
}
