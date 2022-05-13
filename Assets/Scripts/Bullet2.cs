using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float magnetArea = 1f;
    public float speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {

        Collider[] hitColliders = Physics.OverlapSphere(transform.position, magnetArea);

        foreach (var collider in hitColliders)
        {
            if (collider.CompareTag("BulletObject"))
            {
                Transform gun2Object = collider.transform;

                if (!collider.GetComponent<Gun2ObjectController>().isInOrbit)
                {
                    gun2Object.position = Vector3.MoveTowards(gun2Object.position, transform.position + new Vector3(0.1f, 0.1f, 0.1f), speed * Time.deltaTime);

                    if (Mathf.Abs((gun2Object.position.x - transform.position.x)) <= 0.1f)
                    {
                        //Debug.Log("Ya está en orbita");
                        collider.GetComponent<Gun2ObjectController>().isInOrbit = true;
                        gun2Object.SetParent(transform);
                    }
                 }
            }
        }
    }
}
