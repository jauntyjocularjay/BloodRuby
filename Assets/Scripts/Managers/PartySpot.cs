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
    private float interval = 3.0f;
    private float time_1;
    private float time_2;


    private void Start()
    {
        portrait.GetComponent<Image>().sprite = battler.portrait;
        shadow.GetComponent<Image>().sprite = battler.portrait;
        time_1 = Time.time;
        animator.GetComponent<AnimatorController>();
        AdjustInterval();
    }

    public void AdjustInterval()
    {
        interval += UnityEngine.Random.Range(0.0f, 1.9f);
    }

    private void FixedUpdate()
    {
        IdleAnimation();
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

