using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Man")]
public class Man: BattlerData
{
    private void Awake()
    {
        genus = Genus.Man;
        primaryAttribute = Attribute.Strength;
    }

}