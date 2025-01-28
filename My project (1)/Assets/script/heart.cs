using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    float score = 0;
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "heart")
        {
            Destroy(collision.gameObject);
            score++;
            Debug.Log("Zdobyto" + score + "heart");
        }
    }

}
