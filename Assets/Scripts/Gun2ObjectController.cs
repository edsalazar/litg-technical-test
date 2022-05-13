using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2ObjectController : MonoBehaviour
{
    public Transform bulletToRotate;

    public bool isInOrbit = false;


    public float rotationSpeed = 800f;

    void Start()
    {
        
    }

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        if (transform.parent != null)
        {
            if (transform.parent.CompareTag("Bullet") && isInOrbit)
            {
                bulletToRotate = transform.parent;
                transform.RotateAround(bulletToRotate.transform.position, bulletToRotate.transform.forward, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
