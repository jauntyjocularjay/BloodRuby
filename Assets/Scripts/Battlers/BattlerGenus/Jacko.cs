using UnityEngine;



[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Jacko")]
public class Jacko : BattlerData
{
    private void Awake()
    {
        genus = Genus.Jacko;
        primaryAttribute = Attribute.Wisdom;
    }
}
