using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Head")]
public class Head : BattlerData
{
    private void Awake()
    {
        genus = Genus.Head;
        primaryAttribute = Attribute.Wisdom;
    }
}
