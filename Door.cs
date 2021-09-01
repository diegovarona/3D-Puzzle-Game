using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator doorAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door Trigger"))
        {
            doorAnimationController.SetBool("Play", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door Trigger"))
        {
            doorAnimationController.SetBool("Play", false);
        }
    }
}
