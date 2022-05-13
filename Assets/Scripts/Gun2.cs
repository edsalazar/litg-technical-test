using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public Transform bulletOrigin;
    public GameObject bullet;

    public float force = 300f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }
    void Shoot()
    {
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.position = bulletOrigin.position;
        bulletObject.transform.forward = bulletOrigin.transform.forward;
        bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * force);
        Destroy(bulletObject, 5f);

    }
}
