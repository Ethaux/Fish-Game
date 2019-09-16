using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            anim.Play("Fishing Cast");
        }
    }
}
