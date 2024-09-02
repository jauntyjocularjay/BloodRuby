using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Fungus")]
public class Fungus : BattlerData
{
    private void Awake()
    {
        genus = Genus.Fungus;
        primaryAttribute = Attribute.Strength;
    }
}
