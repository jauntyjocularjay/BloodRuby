using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Gator")]
public class Gator : BattlerData
{
    private void Awake()
    {
        genus = Genus.Gator;
        primaryAttribute = Attribute.Strength;
    }
}
