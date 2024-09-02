using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Demon")]
public class Demon : BattlerData
{
    private void Awake()
    {
        genus = Genus.Demon;
        primaryAttribute = Attribute.Wisdom;
    }
}
