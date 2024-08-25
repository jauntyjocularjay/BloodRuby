using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class PartySpot : MonoBehaviour
{
    public BattlerData battler;
    public Image portrait;
    public Image shadow;
    public Image healthBarFill;
    public Animator portraitAnimator;
    public Animator shadowAnimator;
    private float interval = 1000.0f;
    private float time_1;


    private void Start()
    {
        portrait.GetComponent<Image>().sprite = battler.portrait;
        shadow.GetComponent<Image>().sprite = battler.portrait;
        time_1 = Time.time;
        portraitAnimator.GetComponent<AnimatorControllerPlayable>();
        shadowAnimator.GetComponent<AnimatorController>();
    }

    private void FixedUpdate()
    {
        portraitAnimator.SetTrigger("hit");
        portraitAnimator.ResetTrigger("hit");
        shadowAnimator.SetTrigger("hit");
        shadowAnimator.ResetTrigger("hit");
        portraitAnimator.SetTrigger("attack");
        portraitAnimator.ResetTrigger("attack");
        shadowAnimator.SetTrigger("attack");
        shadowAnimator.ResetTrigger("attack");
        
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

