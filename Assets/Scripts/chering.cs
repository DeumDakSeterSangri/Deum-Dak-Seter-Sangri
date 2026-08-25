using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chering : MonoBehaviour
{
    private Animator anim;
    private float targetSeconds = 0.2f;
    private float holdTime = 0f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // GetKey returns true every frame the key is held down
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("clik", true);
            anim.SetTrigger("clicktriger");

            // Accumulate hold time across frames
            holdTime += Time.deltaTime;

            if (holdTime >= targetSeconds)
            {
                anim.SetBool("isHold", true);
            }
        }
        else
        {
            // Reset state when space bar is released
            anim.SetBool("clik", false);
            anim.SetBool("isHold", false);
            holdTime = 0f;
        }
    }
}