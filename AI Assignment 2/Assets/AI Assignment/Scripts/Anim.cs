using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Anim : MonoBehaviour
{
    public Animator anim;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetTrigger("Walk");

        if(rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            anim.SetTrigger("Idle");
        }
    }
}
