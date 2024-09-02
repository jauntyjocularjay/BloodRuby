using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Mage")]
public class Mage : BattlerData
{
    private void Awake()
    {
        genus = Genus.Mage;
        primaryAttribute = Attribute.Wisdom;
    }
}
