using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] guns;
    public GameObject[] gunModels;

    public GameObject currentGun;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.CompareTag(GameNames.GunModel))
        {
            ActivateSelectedGun(hit.gameObject);
        }
    }

    void ActivateSelectedGun(GameObject gunModel)
    {
        DropCurrentGun(currentGun);

        if (gunModel.name.Equals(GameNames.Gun1Model))
        {
            currentGun = guns[0];

            guns[0].SetActive(true);
            guns[1].SetActive(false);
            guns[2].SetActive(false);
        }

        else if (gunModel.name.Equals(GameNames.Gun2Model))
        {
            currentGun = guns[1];

            guns[1].SetActive(true);
            guns[0].SetActive(false);
            guns[2].SetActive(false);
        }

        else if (gunModel.name.Equals(GameNames.Gun3Model))
        {
            currentGun = guns[2];

            guns[2].SetActive(true);
            guns[0].SetActive(false);
            guns[1].SetActive(false);
        }

        gunModel.SetActive(false);
    }

    void DropCurrentGun(GameObject currentGun)
    {
        if(currentGun != null)
        {
            if (currentGun.Equals(guns[0]))
            {
                gunModels[0].transform.localPosition = new Vector3(transform.position.x, 0.3f, transform.position.z) - Vector3.right - Vector3.forward;
                gunModels[0].SetActive(true);
            }

            else if (currentGun.Equals(guns[1]))
            {
                gunModels[1].transform.localPosition = new Vector3(transform.position.x, 0.3f, transform.position.z) - Vector3.right - Vector3.forward;
                gunModels[1].SetActive(true);
            }

            else if (currentGun.Equals(guns[2]))
            {
                gunModels[2].transform.localPosition = new Vector3(transform.position.x, 0.3f, transform.position.z) - Vector3.right - Vector3.forward;
                gunModels[2].SetActive(true);
            }
        }
    }
}
