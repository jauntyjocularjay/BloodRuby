using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public int screenWidth = 1920;
    public GameObject middleground;
    public int middlegroundWidth = 3240;
    public Vector2 middlegroundOrigination;
    public FractionScale middleDX;
    public GameObject foreground;
    public int foregroundWidth = 4320;
    public FractionScale foreDX;
    public Vector2 foregroundOrigination;
    public int deltaPX = 8;

    public void Start()
    {
        middlegroundOrigination = new Vector2 (
            middleground.transform.position.x,
            middleground.transform.position.y
        );

        middleDX = new(0,middlegroundWidth - screenWidth);

        foregroundOrigination = new Vector2 (
            foreground.transform.position.x,
            foreground.transform.position.y
        );

        foreDX = new(0,foregroundWidth - screenWidth);
    }
    public void FixedUpdate()
    {
        Vector2 vec2 = middleground.GetComponent<Transform>().position;

        if(middleDX.Full())
        {
            middleground.transform.position = middlegroundOrigination;
            foreDX.SetNumerator(0);
        }
        middleDX.Increment(deltaPX/2);

        middleground.transform.position = new Vector2(vec2.x + (deltaPX/2), vec2.y);

        vec2 = foreground.GetComponent<Transform>().position;

        if(foreDX.Full())
        {
            foreground.transform.position = foregroundOrigination;
            foreDX.SetNumerator(0);
        }
        foreDX.Increment(deltaPX);
        foreground.transform.position = new Vector2(vec2.x + deltaPX, vec2.y);

        Debug.Log(middleDX.ToString());
        Debug.Log($"Foreground origination @ {foregroundOrigination}");
        Debug.Log(foreDX.ToString());
        Debug.Log($"Midground origination @ {middlegroundOrigination}");

    }


}
