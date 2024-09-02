using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Orb")]
public class Orb : BattlerData
{
    private void Awake()
    {
        genus = Genus.Orb;
        primaryAttribute = Attribute.Wisdom;
    }
}
