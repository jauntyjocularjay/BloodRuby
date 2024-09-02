using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Knight")]
public class Knight : BattlerData
{
    private void Awake()
    {
        genus = Genus.Knight;
        primaryAttribute = Attribute.Strength;
    }
}
