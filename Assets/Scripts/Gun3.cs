using UnityEngine;

public class Gun3 : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletOrigin;

    [Range(300f, 1000f)]
    public float force = 500f;

    [Range(0.5f, 3f)]
    public float timeToStop = 0.5f;

    private bool fire = false;

    void Update()
    {
        if(Input.GetButtonDown(GameNames.Fire1))
        {
            fire = true;
        }
    }

    void FixedUpdate()
    {
        if(fire)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.SetPositionAndRotation(bulletOrigin.position, Quaternion.Euler(Vector3.zero));
        bulletObject.transform.forward = bulletOrigin.transform.forward;

        bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * force);
        bulletObject.GetComponent<Bullet3>().SetTimeToStop(timeToStop);

        fire = false;
    }
}