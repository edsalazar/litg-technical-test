using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    private Vector3 target = new(0.34f, 4.92f, 7.59f);
    private float launchAngle = 25f;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().AddForce(transform.forward * 200);
    }

    // Update is called once per frame
    void Update()
    {
        Launch();
    }

    void Launch()
    {

        //transform.position += transform.forward * speed * Time.deltaTime;

        //Debug.Log("Launched!");
        //Vector3 projectileXZPos = new Vector3(transform.position.x, 0.1f, transform.position.z);
        //float R = Vector3.Distance(projectileXZPos, target);
        //float G = Physics.gravity.y;
        //float tanAlpha = Mathf.Tan(launchAngle * Mathf.Deg2Rad);
        //float H = target.y - transform.position.y;

        //float Vz = Mathf.Sqrt(G * R * R / (speed * (H - R * tanAlpha)));
        //float Vy = tanAlpha * Vz;

        //Vector3 localVelocity = new(0f, Vy, Vz);
        //Vector3 globalVelocity = transform.TransformDirection(localVelocity);

        //GetComponent<Rigidbody>().velocity = globalVelocity;
    }
}
