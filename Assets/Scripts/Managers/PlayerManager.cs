using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerData")]
public class PlayerManager : ScriptableObject
{
    public int XP;
    public int xpToNextLevel;
    public int GP;

}