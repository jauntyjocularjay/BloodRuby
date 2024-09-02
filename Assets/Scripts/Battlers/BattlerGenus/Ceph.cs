using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Battler/Monster/Ceph")]
public class Ceph : BattlerData
{
    private void Awake()
    {
        genus = Genus.Ceph;
        primaryAttribute = Attribute.Strength;
    }
}
