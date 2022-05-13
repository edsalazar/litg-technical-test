using UnityEngine;

public class Gun1 : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletOrigin;
    public Transform target;

    public float force = 100f;

    private GameObject newBullet;

    private Vector3 targetPoint;
    private Vector3 targetPoint2;

    public float angle = -45f;

    public float speed = 20f;

    void Start()
    {

    }

    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            GetTargetPosition();
            Shoot();
            //Shoot2();
        } 
    }

    void GetTargetPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition += Camera.main.transform.forward * 10f;
        targetPoint = Camera.main.ScreenToWorldPoint(mousePosition);

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            targetPoint2 = hit.point;
        }

        else
        {
            targetPoint2 = ray.GetPoint(1000f);
        }
    }

    void Shoot()
    {

        Debug.Log("Shooot");

        bulletOrigin.localRotation = Quaternion.Euler(angle, 0f, 0f);
 
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.position = bulletOrigin.position;

        bulletObject.transform.rotation = Quaternion.Euler(Vector3.zero);

        bulletObject.transform.forward = bulletOrigin.transform.forward;
        bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * force);

        Destroy(bulletObject, 5);
    }

    void Shoot2()
    {
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.position = bulletOrigin.position;
        bulletObject.GetComponent<Rigidbody>().velocity = (targetPoint2 - bulletOrigin.position).normalized * speed;

        Destroy(bulletObject, 5);
    }
}
