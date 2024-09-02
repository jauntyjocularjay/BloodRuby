using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Eagle")]
public class Eagle : BattlerData
{
    private void Awake()
    {
        genus = Genus.Eagle;
        primaryAttribute = Attribute.Agility;
    }
}
