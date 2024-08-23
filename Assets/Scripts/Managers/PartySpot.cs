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

        spriteRenderer.sprite = battler.portrait;
        shadowRenderer.sprite = battler.portrait;

    }


}
