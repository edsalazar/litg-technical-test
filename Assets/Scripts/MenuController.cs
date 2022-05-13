using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour

{
    public Button firstAnimationButton;
    public Animator playerAnimator;

    void Start()
    {
        SelectFirstButtonAtStart();
    }

    public void SetHouseDanceAnimation()
    {
        playerAnimator.SetBool(GameNames.isMacarenaDance, false);
        playerAnimator.SetBool(GameNames.isWaveHipHopDance, false);
        playerAnimator.SetBool(GameNames.isHouseDance, true);

        GameManager.Instance.SetSelectedAnimation(GameNames.isHouseDance);
    }

    public void SetMacarenaDanceAnimation()
    {
        playerAnimator.SetBool(GameNames.isWaveHipHopDance, false);
        playerAnimator.SetBool(GameNames.isHouseDance, false);
        playerAnimator.SetBool(GameNames.isMacarenaDance, true);

        GameManager.Instance.SetSelectedAnimation(GameNames.isMacarenaDance);
    }

    public void SetWaveHipHopDanceAnimation()
    {
        playerAnimator.SetBool(GameNames.isHouseDance, false);
        playerAnimator.SetBool(GameNames.isMacarenaDance, false);
        playerAnimator.SetBool(GameNames.isWaveHipHopDance, true);

        GameManager.Instance.SetSelectedAnimation(GameNames.isWaveHipHopDance);
    }

    void SelectFirstButtonAtStart()
    {
        if (firstAnimationButton != null)
        {
            firstAnimationButton.Select();
        }
    }
}
