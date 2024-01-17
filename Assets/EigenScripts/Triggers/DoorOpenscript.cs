using OVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenscript : MonoBehaviour
{
    public Animator animator;
    public float sphereRadius;
    public LayerMask layerMask;
    public AudioSource doorOpenSound;
    public bool isSoundPlaying;

    public void Update()
    {
        if(Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            animator.SetInteger("DoorOpens", 1);
            if (!isSoundPlaying)
            {
                doorOpenSound.Play();
                isSoundPlaying = true;
            }
            animator.SetInteger("DoorsOpens", 0);
        }
        else
        {
            animator.SetInteger("DoorOpens", 2);
            if (isSoundPlaying)
            {
                doorOpenSound.Play();
                isSoundPlaying = false;
            }
            animator.SetInteger("DoorsOpens", 0);
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
