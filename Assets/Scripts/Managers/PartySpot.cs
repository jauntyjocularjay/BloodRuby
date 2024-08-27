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
    public Animator animator;
    private float interval = 1000.0f;
    private float time_1;
    private float time_2;


    private void Start()
    {
        portrait.GetComponent<Image>().sprite = battler.portrait;
        shadow.GetComponent<Image>().sprite = battler.portrait;
        time_1 = Time.time;
        animator.GetComponent<AnimatorController>();
    }

    private void FixedUpdate()
    {
        time_2 = Time.time;

        if(time_2 - time_1 >= interval)
        {
            animator.SetTrigger("idle");
        }

        Debug.Log("updated...");
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

