using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    private float magnetArea = 1f;
    private float speed = 20f;

    private Vector3 objectPositionOffset = new Vector3(0.1f, 0.1f, 0.1f);

    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, magnetArea);

        foreach (var collider in hitColliders)
        {
            if (collider.CompareTag(GameNames.BulletObject))
            {
                Transform gun2Object = collider.transform;

                if (!collider.GetComponent<Gun2ObjectController>().GetIsInOrbit())
                {
                    gun2Object.position = Vector3.MoveTowards(gun2Object.position, transform.position + objectPositionOffset, speed * Time.deltaTime);

                    if (Mathf.Abs((gun2Object.position.x - transform.position.x)) <= objectPositionOffset.x)
                    {
                        collider.GetComponent<Gun2ObjectController>().SetIsInOrbit(true);
                        gun2Object.SetParent(transform);
                    }
                 }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    public float GetMagnetArea()
    {
        return magnetArea;
    }

    public void SetMagnetArea(float _magnetArea)
    {
        magnetArea = _magnetArea;
    }
}