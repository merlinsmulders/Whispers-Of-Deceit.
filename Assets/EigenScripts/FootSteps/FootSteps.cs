using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    CharacterController controller;
    public AudioSource footSteps;
    void Start()
    {
        controller.GetComponent<CharacterController>();
    }

    void Update()
    {
        //if (controller.velocity.magnitude > Mathf.Epsilon)
        //{
        //    footSteps.Play();
        //}
        //else if (controller.velocity.magnitude == Mathf.Epsilon)
        //{
        //    footSteps.Stop();
        //}
    }
}
