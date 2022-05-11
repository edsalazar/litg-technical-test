using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour

{
    public Animator playerAnimator;

    private const string isHouseDance = "isHouseDance";
    private const string isMacarenaDance = "isMacarenaDance";
    private const string isWaveHipHopDance = "isWaveHipHopDance";

    public void SetHouseDanceAnimation()
    {
        playerAnimator.SetBool(isMacarenaDance, false);
        playerAnimator.SetBool(isWaveHipHopDance, false);
        playerAnimator.SetBool(isHouseDance, true);
    }

    public void SetMacarenaDanceAnimation()
    {
        playerAnimator.SetBool(isWaveHipHopDance, false);
        playerAnimator.SetBool(isHouseDance, false);
        playerAnimator.SetBool(isMacarenaDance, true);
    }

    public void SetWaveHipHopDanceAnimation()
    {
        playerAnimator.SetBool(isHouseDance, false);
        playerAnimator.SetBool(isMacarenaDance, false);
        playerAnimator.SetBool(isWaveHipHopDance, true);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Scenario");
    }
}
