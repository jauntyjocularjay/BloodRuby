using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Dragon")]
public class Dragon : BattlerData
{
    private void Awake()
    {
        genus = Genus.Dragon;
        primaryAttribute = Attribute.Agility;
    }
}
