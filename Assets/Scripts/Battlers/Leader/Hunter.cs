using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Leader/Hunter")]
public class Hunter: BattlerData
{
    private void Awake()
    {
        genus = Genus.Hunter;
        primaryAttribute = Attribute.Agility;
    }

}