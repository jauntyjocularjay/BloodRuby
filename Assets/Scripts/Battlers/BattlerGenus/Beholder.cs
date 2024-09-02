using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Beholder")]
public class Beholder: BattlerData
{
    private void Awake()
    {
        genus = Genus.Beholder;
        primaryAttribute = Attribute.Wisdom;
    }
}
