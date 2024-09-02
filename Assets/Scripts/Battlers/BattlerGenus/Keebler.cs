using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Keebler")]
public class Keebler : BattlerData
{
    private void Awake()
    {
        genus = Genus.Keebler;
        primaryAttribute = Attribute.Agility;
    }
}
