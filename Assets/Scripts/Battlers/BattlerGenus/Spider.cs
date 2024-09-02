using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Spider")]
public class Spider : BattlerData
{
    private void Awake()
    {
        genus = Genus.Spider;
        primaryAttribute = Attribute.Agility;
    }
}
