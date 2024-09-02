using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Grater")]
public class Grater : BattlerData
{
    private void Awake()
    {
        genus = Genus.Grater;
        primaryAttribute = Attribute.Strength;
    }
}
