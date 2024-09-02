using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Crab")]
public class Crab : BattlerData
{
    private void Awake()
    {
        genus = Genus.Crab;
        primaryAttribute = Attribute.Agility;
    }
}
