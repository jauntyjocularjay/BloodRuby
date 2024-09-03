using System;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class PartySpot : MonoBehaviour
{
    public BattlerData battler;
    public Image portrait;
    public Image shadow;
    public Image healthBarFill;
    public Animator animator;
    public OverlayManager overlayManager;
    private float interval;
    private float time_1;
    private float time_2;


    private void Start()
    {
        portrait.GetComponent<Image>().sprite = battler.portrait;
        shadow.GetComponent<Image>().sprite = battler.portrait;
        time_1 = Time.time;
        animator.runtimeAnimatorController = battler.animator;
        interval = UnityEngine.Random.Range(1.0f, 3.0f);
        portrait = shadow;
    }

    private void FixedUpdate()
    {
        IdleAnimation();
        // HitAnimation();
        // AttackAnimation();
    }

    private void AttackAnimation()
    {
        animator.SetTrigger("attack");
        time_1 = Time.time;
    }

    private void HitAnimation()
    {
        animator.SetTrigger("hit");
        time_1 = Time.time;
    }

    private void IdleAnimation()
    {
        time_2 = Time.time;

        if(time_2 - time_1 >= interval)
        {
            time_1 = Time.time;
            animator.SetTrigger("idle");
        }
    }

}

