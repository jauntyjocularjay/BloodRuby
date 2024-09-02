using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Lich")]
public class Lich : BattlerData
{
    private void Awake()
    {
        genus = Genus.Lich;
        primaryAttribute = Attribute.Wisdom;
    }
}
