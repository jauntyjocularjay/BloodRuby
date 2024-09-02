using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Djinn")]
public class Djinn : BattlerData
{
    private void Awake()
    {
        genus = Genus.Djinn;
        primaryAttribute = Attribute.Wisdom;
    }
}
