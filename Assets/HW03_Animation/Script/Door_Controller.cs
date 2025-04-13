using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public Animator Animator;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 toPlayer = other.transform.position - transform.position;
            float dot = Vector3.Dot(transform.forward, toPlayer);

            if (dot >= 0)
            {
                 Debug.Log("문열림!");
                Animator.SetInteger("status", 2);
            }
            else
            {
                Debug.Log("문열림!");
                Animator.SetInteger("status", 1);
            }
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 toPlayer = other.transform.position - transform.position;
            float dot = Vector3.Dot(transform.forward, toPlayer);

            if (dot >= 0)
            {
                Animator.SetInteger("status", 3);
                Debug.Log("문닫힘!");
            }
            else
            {
                Animator.SetInteger("status", 4);
                Debug.Log("문닫힘!");
            }
        }
    }

}
