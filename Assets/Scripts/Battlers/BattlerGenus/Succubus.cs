using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Succubus")]
public class Succubus : BattlerData
{
    private void Awake()
    {
        genus = Genus.Succubus;
        primaryAttribute = Attribute.Wisdom;
    }
}
