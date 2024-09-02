using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Bird")]
public class Bird: BattlerData
{
    private void Awake()
    {
        genus = Genus.Bird;
        primaryAttribute = Attribute.Agility;
    }

}
