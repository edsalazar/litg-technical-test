using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2ObjectController : MonoBehaviour
{
    private Transform bulletToRotate;

    public float rotationSpeed = 500f;
    private bool isInOrbit = false;

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        if (transform.parent != null)
        {
            // If object is child of a bullet, then it rotates around the bullet

            if (transform.parent.CompareTag(GameNames.Bullet) && isInOrbit)
            {
                bulletToRotate = transform.parent;
                transform.RotateAround(bulletToRotate.transform.position, bulletToRotate.transform.forward, rotationSpeed * Time.deltaTime);
            }
        }
    }

    public bool GetIsInOrbit()
    {
        return isInOrbit;
    }

    public void SetIsInOrbit(bool _isInOrbit)
    {
        isInOrbit = _isInOrbit;
    }
}