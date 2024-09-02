using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Slime")]
public class Slime : BattlerData
{
    private void Awake()
    {
        genus = Genus.Slime;
        primaryAttribute = Attribute.Strength;
    }
}
