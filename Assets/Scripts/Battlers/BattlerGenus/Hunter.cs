using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Hunter")]
public class Hunter: BattlerData
{
    private void Awake()
    {
        genus = Genus.Hunter;
        primaryAttribute = Attribute.Strength;
    }

}