using UnityEngine;



[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Hornet")]
public class Hornet : BattlerData
{
    private void Awake()
    {
        genus = Genus.Hornet;
        primaryAttribute = Attribute.Agility;
    }
}
