using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Boar")]
public class Boar: BattlerData
{
    private void Awake()
    {
        genus = Genus.Boar;
        primaryAttribute = Attribute.Strength;
    }

}
