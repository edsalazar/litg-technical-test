using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    public Animator playerAnimator;

    public Vector3 gun2ObjectMinSpawnZone;
    public Vector3 gun2ObjectMaxSpawnZone;
    public GameObject gun2Object;

    [Range(10, 100)]
    public int numberOfObjects = 100;

    void Start()
    {
        SpawnGun2Objects();

        if (GameManager.Instance != null)
        {
            ActivatePlayerAnimation(GameManager.Instance.GetSelectedAnimation());
        }
    }

    void ActivatePlayerAnimation(string animation)
    {
        if(animation.Equals(GameNames.isHouseDance))
        {
            playerAnimator.SetBool(GameNames.isMacarenaDance, false);
            playerAnimator.SetBool(GameNames.isWaveHipHopDance, false);
            playerAnimator.SetBool(GameNames.isHouseDance, true);
        }

        else if(animation.Equals(GameNames.isMacarenaDance))
        {
            playerAnimator.SetBool(GameNames.isWaveHipHopDance, false);
            playerAnimator.SetBool(GameNames.isHouseDance, false);
            playerAnimator.SetBool(GameNames.isMacarenaDance, true);
        }

        else
        {
            playerAnimator.SetBool(GameNames.isHouseDance, false);
            playerAnimator.SetBool(GameNames.isMacarenaDance, false);
            playerAnimator.SetBool(GameNames.isWaveHipHopDance, true);
        }
    }

    void SpawnGun2Objects()
    {
        for(int i=0; i<numberOfObjects; i++)
        {
            float xAxis = Random.Range(gun2ObjectMinSpawnZone.x, gun2ObjectMaxSpawnZone.x);
            float yAxis = Random.Range(gun2ObjectMinSpawnZone.y, gun2ObjectMaxSpawnZone.y);
            float zAxis = Random.Range(gun2ObjectMinSpawnZone.z, gun2ObjectMaxSpawnZone.z);

            Instantiate(gun2Object, new Vector3(xAxis, yAxis, zAxis), Quaternion.identity);
        }
    }
}