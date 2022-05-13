using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    public Animator playerAnimator;

    public bool devMode;
    void Start()
    {
        if(!devMode)
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
}
