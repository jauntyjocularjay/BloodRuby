using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject middleground;
    public int middlegroundWidth = 3240;
    public GameObject foreground;
    public int foregroundWidth = 4320;
    public int deltaPX = 8;
    public void FixedUpdate()
    {
        Vector2 vec2 = middleground.GetComponent<Transform>().position;
        middleground.transform.position = new Vector2(vec2.x + (deltaPX/2), vec2.y);
        vec2 = foreground.GetComponent<Transform>().position;
        foreground.transform.position = new Vector2(vec2.x + deltaPX, vec2.y);
    }


}
