using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletOrigin;

    [Range(300f, 1000f)]
    public float force = 300f;

    [Range(0.5f, 2f)]
    public float magnetArea = 1f;

    void Update()
    {
        if(Input.GetButtonDown(GameNames.Fire1))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.position = bulletOrigin.position;
        bulletObject.transform.forward = bulletOrigin.transform.forward;

        bulletObject.GetComponent<Bullet2>().SetMagnetArea(magnetArea);
        bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * force);

        Destroy(bulletObject, 5f);
    }
}