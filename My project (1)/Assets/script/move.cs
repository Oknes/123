using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float VectorX;
    [SerializeField] float VectorY = 0;
    [SerializeField] float VectorZ;
    [SerializeField] float speed = 10;
    // Start is called before the first frame update
     void Instructions()
    {
        Debug.Log("Witam");
    }

    void Start()
    {
        Instructions();
    }

    // Update is called once per frame
    void Move()
    {
        VectorX = Input.GetAxis("Horizontal");
        VectorZ = Input.GetAxis("Vertical");
        transform.Translate(VectorX*Time.deltaTime*speed,VectorY * Time.deltaTime, VectorZ * Time.deltaTime*speed);
    }
    void Update()
    {
        Move();
    }
}
