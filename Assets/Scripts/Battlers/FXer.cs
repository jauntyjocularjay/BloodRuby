using System;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FXer")]
public class FXer : ScriptableObject
{
    public Sprite sprite;
    public AnimatorController animatorController;
    public String[] triggers;

    public Sprite GetSprite()
    {
        return sprite;
    }
}





