using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/FXer")]
public class FXer : ScriptableObject
{
    public Sprite sprite;
    public Image image;
    public AnimatorController animatorController;
    public String[] triggers;

    public Sprite GetSprite()
    {
        return sprite;
    }

}
