using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySpot : MonoBehaviour
{
    public BattlerData battler;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRendererShadow;
    public Image healthBarFill;

    void Start()
    {
        spriteRenderer.sprite = battler.portrait;
        spriteRendererShadow.sprite = battler.portrait;
    }



}
