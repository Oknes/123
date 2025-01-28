using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
  [SerializeField] AudioSource audioSource;
  [SerializeField] AudioClip clipCollision;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(clipCollision);
        }
        else 
        {
           
        }
    }
}