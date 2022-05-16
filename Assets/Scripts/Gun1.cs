using UnityEngine;

public class Gun1 : MonoBehaviour
{
    public Gun1SO gun1SO;

    public GameObject bullet;
    public Transform bulletOrigin;

    [Range(300f, 1000f)]
    public float force = 500f;

    [Range(0f, 90f)]
    public float angle = 45f;

    void Start()
    {
        force = gun1SO.force;
        angle = gun1SO.angle;
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
        // Instantiating bullet with given angle and adding force to move it

        bulletOrigin.localRotation = Quaternion.Euler(-angle, 0f, 0f);
 
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.SetPositionAndRotation(bulletOrigin.position, Quaternion.Euler(Vector3.zero));
        bulletObject.transform.forward = bulletOrigin.transform.forward;

        bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * force);

        Destroy(bulletObject, 5f);
    }
}