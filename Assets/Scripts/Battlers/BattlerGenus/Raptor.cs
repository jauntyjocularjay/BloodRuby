using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Raptor")]
public class Raptor : BattlerData
{
    private void Awake()
    {
        genus = Genus.Raptor;
        primaryAttribute = Attribute.Agility;
    }
}
