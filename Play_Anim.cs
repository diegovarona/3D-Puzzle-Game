using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Anim : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;


    //right
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box Trigger"))
        {
            myAnimationController.SetBool("Play", true);
            myAnimationController2.SetBool("Play", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box Trigger"))
        {
            myAnimationController.SetBool("Play", false);
            myAnimationController2.SetBool("Play", false);
        }
    }
}
