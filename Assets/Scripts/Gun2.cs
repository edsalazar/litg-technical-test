using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public Gun2SO gun2SO;

    public GameObject bullet;
    public Transform bulletOrigin;

    [Range(300f, 1000f)]
    public float force = 300f;

    [Range(0.5f, 2f)]
    public float magneticArea = 1f;

    void Start()
    {
        force = gun2SO.force;
        magneticArea = gun2SO.magneticArea;
    }

    void Update()
    {
        if(Input.GetButtonDown(GameNames.Fire1))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiating bullet with given magnet area and adding force to move it

        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.position = bulletOrigin.position;
        bulletObject.transform.forward = bulletOrigin.transform.forward;

        bulletObject.GetComponent<Bullet2>().SetMagnetArea(magneticArea);
        bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * force);

        Destroy(bulletObject, 5f);
    }
}