using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySpot : MonoBehaviour
{
    public BattlerData battler;
    public Image portrait;
    public Image shadow;
    public Image healthBarFill;
    public Animator portraitAnimator;
    public Animator shadowAnimator;
    private bool attack = false;
    private bool hit = false;
    private float interval = 1000.0f;
    private float time_1;


    private void Start()
    {
        portrait.GetComponent<Image>().sprite = battler.portrait;
        shadow.GetComponent<Image>().sprite = battler.portrait;
        time_1 = Time.time;
    }

    private void FixedUpdate()
    {

        if(attack)
        {
            AttackAnimation();
        }
        else if (hit)
        {
            HitAnimation();
        }
        else
        {
            IdleAnimation();
        }
    }

    private void AttackAnimation()
    {

    }

    private void HitAnimation()
    {

    }

    private void IdleAnimation()
    {
        if(time_1 - interval >= 1.0f)
        {
            time_1 = Time.time;
            
        }
    }

}

