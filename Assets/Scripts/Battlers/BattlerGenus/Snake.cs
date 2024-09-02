using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Snake")]
public class Snake : BattlerData
{
    private void Awake()
    {
        genus = Genus.Snake;
        primaryAttribute = Attribute.Strength;
    }
}
