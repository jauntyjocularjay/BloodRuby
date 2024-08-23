using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySpot : MonoBehaviour
{
    public BattlerData battler;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer shadowRenderer;
    public Image healthBarFill;

    private void Start()
    {
        SpriteRenderer _mSpriteRenderer = spriteRenderer.GetComponent<SpriteRenderer>();
        SpriteRenderer _mSpriteRendererShadow = shadowRenderer.GetComponent<SpriteRenderer>();

        _mSpriteRenderer.sprite = 
            battler.portrait;
        _mSpriteRendererShadow.sprite = 
            battler.portrait;

    }


}
