using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Ghost")]
public class Ghost : BattlerData
{
    private void Awake()
    {
        genus = Genus.Ghost;
        primaryAttribute = Attribute.Wisdom;
    }
}
