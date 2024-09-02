using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Mimic")]
public class Mimic : BattlerData
{
    private void Awake()
    {
        genus = Genus.Mimic;
        primaryAttribute = Attribute.Strength;
    }
}
