using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Elk")]
public class Elk : BattlerData
{
    private void Awake()
    {
        genus = Genus.Elk;
        primaryAttribute = Attribute.Strength;
    }
}
