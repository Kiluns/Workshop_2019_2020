using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionDeuxiemePartie : MonoBehaviour
{
    public float speed = 0.5f;
    bool up = false;
    bool down = false;

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            print("move up");
            transform.position += transform.up * Time.deltaTime * speed;
        }
        if (down)
        {
            print("move down");
            transform.position -= transform.up * Time.deltaTime * speed;
        }
    }
    void OnGUI()
    {
        Event e = Event.current;

        if (e.type == EventType.ScrollWheel)
        {
            if (e.delta.y > 0)
            {
                down = true;
            }
            else
            {
                up = true;
            }
        }
        else
        {
            up = false;
            down = false;
        }
    }
}