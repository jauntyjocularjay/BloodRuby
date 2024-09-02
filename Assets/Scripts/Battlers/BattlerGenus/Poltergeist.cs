using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Poltergeist")]
public class Poltergeist : BattlerData
{
    private void Awake()
    {
        genus = Genus.Poltergeist;
        primaryAttribute = Attribute.Wisdom;
    }
}
