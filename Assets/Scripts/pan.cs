using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pan : MonoBehaviour
{
    private static Animator anim;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // GetKey returns true every frame the key is held down
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("nomal", false);
        }
        else
        {
            // Reset state when space bar is released
            anim.SetBool("nomal", true);
            anim.SetBool("miss", false);
            anim.SetBool("good", false);
            anim.SetBool("per", false);
        }
    }

    public static void AniMiss()
    {
        anim.SetBool("miss", true);
    }
    public static void AniGood()
    {
        anim.SetBool("good", true);
    }
    public static void AniPerfect()
    {
        anim.SetBool("per", true);
    }
}