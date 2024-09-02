using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Frog")]
public class Frog : BattlerData
{
    private void Awake()
    {
        genus = Genus.Frog;
        primaryAttribute = Attribute.Agility;
    }
}
