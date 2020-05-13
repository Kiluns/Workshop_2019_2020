using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUBPlayer : MonoBehaviour
{
    public Animator anim;
    public bool isWalkEnable;
    public float Speed = 1.5f;
    private bool isFlipped;

    void Start()
    {
        isWalkEnable = true;
        isFlipped = true;
        transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }

    void Update()
    {
        anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }

    void FixedUpdate()
    {
        if (isWalkEnable && Input.GetKey(KeyCode.Q) && transform.position.x < 6.45f)
        {
            if (!isFlipped)
            {
                isFlipped = true;
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            transform.Translate(Speed * Time.deltaTime, 0f, 0f);
        }
        if (isWalkEnable && Input.GetKey(KeyCode.D) && transform.position.x > -5.5f)
        {
            if (isFlipped)
            {
                isFlipped = false;
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.Translate(-Speed * Time.deltaTime, 0f, 0f);
        }
    }
}
