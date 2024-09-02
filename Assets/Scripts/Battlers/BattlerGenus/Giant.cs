using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Giant")]
public class Giant : BattlerData
{
    private void Awake()
    {
        genus = Genus.Giant;
        primaryAttribute = Attribute.Strength;
    }
}
