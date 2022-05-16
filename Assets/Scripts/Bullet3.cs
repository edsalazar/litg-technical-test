using System.Collections;
using UnityEngine;

public class Bullet3 : MonoBehaviour
{
    private Rigidbody bulletRigidbody;

    private float timeCounter = 0f;
    private float timeToStop = 0.5f;

    Vector3 currentVelocity;

    public GameObject explosionParticles;

    private bool isStopped = false;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        currentVelocity = bulletRigidbody.velocity;
    }

    void FixedUpdate()
    {
        // Decreasing bullet velocity during given time until it's stopped

        timeCounter += Time.deltaTime;
        bulletRigidbody.velocity = Vector3.Lerp(currentVelocity, Vector3.zero, timeCounter/timeToStop);

        if (bulletRigidbody.velocity.Equals(Vector3.zero) && !isStopped)
        {
            isStopped = true;

            SetParticles();
        }
    }

    void SetParticles()
    {
        // Showing particles when bullet is stopped and starting coroutine with particle's time duration before whole object is destroyed

        GameObject explosion = Instantiate(explosionParticles, transform.position, transform.rotation);
        StartCoroutine(WaitBeforeExplosion(explosion));
        gameObject.transform.localScale = Vector3.zero;
    }

    IEnumerator WaitBeforeExplosion(GameObject explosionGO)
    {
        yield return new WaitForSeconds(explosionGO.GetComponent<ParticleSystem>().main.duration);

        Destroy(explosionGO);
        Destroy(gameObject);
    }

    public float GetTimeToStop()
    {
        return timeToStop;
    }

    public void SetTimeToStop(float _timeToStop)
    {
        timeToStop = _timeToStop;
    }
}