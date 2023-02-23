using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterAnimation : MonoBehaviour
{
    private Animator animation;
    //public Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        //m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animation.SetBool("Walk", true);
        /*animation.SetBool("Slash", false);
        animation.SetBool("Jab", false);

        //if (animation.SetTrigger("Collide"))
        //{
            animation.SetBool("Slash", true);
            animation.SetBool("Jab", true);
        //}*/
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("enemy"))
        {
            Debug.Log("COLLIDED");
            animation.SetBool("Slash", true);
            animation.SetBool("Jab", true);
            //animator.SetTrigger("Die");
        }
    }
}
