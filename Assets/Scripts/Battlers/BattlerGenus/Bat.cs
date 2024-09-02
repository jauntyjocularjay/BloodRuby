using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Bat")]
public class Bat: BattlerData
{
    private void Awake()
    {
        genus = Genus.Bat;
        primaryAttribute = Attribute.Agility;
    }

}
