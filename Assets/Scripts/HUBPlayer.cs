using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUBPlayer : MonoBehaviour
{
    public float Speed = 1.5f;
    private bool isFlipped;

    void Start()
    {
        isFlipped = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q) && transform.position.x < 6.45f)
        {
            if (!isFlipped)
            {
                isFlipped = true;
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            transform.Translate(Speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x > -5.5f)
        {
            if (isFlipped)
            {
                isFlipped = false;
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.Translate(-Speed * Time.deltaTime, 0f, 0f);
        }
    }
}
