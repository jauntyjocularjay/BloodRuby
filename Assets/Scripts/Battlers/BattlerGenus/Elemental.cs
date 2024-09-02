using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Elemental")]
public class Elemental : BattlerData
{
    private void Awake()
    {
        genus = Genus.Elemental;
        primaryAttribute = Attribute.Wisdom;
    }
}
