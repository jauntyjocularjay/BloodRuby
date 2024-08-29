using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public int tileWidth = 1080;
    public GameObject middleground;
    public Vector2 middlegroundOrigination;
    public FractionScale middleDX;
    public GameObject foreground;
    public FractionScale foreDX;
    public Vector2 foregroundOrigination;
    public int deltaPX = 8;

    public void Start()
    {
        middlegroundOrigination = new Vector2 (
            middleground.transform.position.x,
            middleground.transform.position.y
        );

        middleDX = new(0,tileWidth);

        foregroundOrigination = new Vector2 (
            foreground.transform.position.x,
            foreground.transform.position.y
        );

        foreDX = new(0,3 * tileWidth);
    }
    public void FixedUpdate()
    {
        UpdateMiddleground();
        UpdateForeground();
    }

    public void UpdateMiddleground()
    {
        Vector3 middlegroundCurrent = middleground.GetComponent<Transform>().position;
        if(middleDX.Full())
        {
            middleground.transform.position = middlegroundOrigination;
            middleDX.SetNumerator(0);
        }
        else {
            middleDX.Increment(deltaPX/2);
            middleground.transform.position = new Vector3(
                middlegroundCurrent.x + (deltaPX/2), 
                middlegroundCurrent.y,
                0
            );
        }
    }

    public void UpdateForeground()
    {
        Vector3 foregroundCurrent = foreground.GetComponent<Transform>().position;

        if(foreDX.Full())
        {
            foreDX.Increment(deltaPX);
            foreground.transform.position = new Vector2(
                foregroundCurrent.x + deltaPX, 
                foregroundCurrent.y
            );

            foreground.transform.position = foregroundOrigination;
            foreDX.SetNumerator(0);
        }
        else
        {
            foreDX.Increment(deltaPX);
            foreground.transform.position = new Vector2(
                foregroundCurrent.x + deltaPX, 
                foregroundCurrent.y
            );
        }
    }
}
