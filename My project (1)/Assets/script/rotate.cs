using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(MoveHeartTowardsPlayer(transform,gameObject, other.transform ));
        }
    }
    IEnumerator MoveHeartTowardsPlayer(Transform heart, GameObject heartObject, Transform Player)
    {
        float duration = 1f;
        float elapsed = 0f;
        float speed = 3f;

        while (elapsed < duration)
        {
            heart.position = Vector3.MoveTowards(heart.position, Player.position, speed * Time.deltaTime);

            elapsed += Time.deltaTime;
            yield return null;
        }
        
        Destroy(heartObject);
    }
}
