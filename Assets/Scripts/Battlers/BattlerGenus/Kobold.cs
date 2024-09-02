using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Kobold")]
public class Kobold : BattlerData
{
    private void Awake()
    {
        genus = Genus.Kobold;
        primaryAttribute = Attribute.Strength;
    }
}
