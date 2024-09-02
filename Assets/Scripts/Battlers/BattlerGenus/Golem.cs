using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Golem")]
public class Golem : BattlerData
{
    private void Awake()
    {
        genus = Genus.Golem;
        primaryAttribute = Attribute.Strength;
    }
}
