using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private string selectedAnimation;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if(selectedAnimation == "")
        {
            SetSelectedAnimation(GameNames.isHouseDance);
        }
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void SetSelectedAnimation(string animation)
    {
        selectedAnimation = animation;
    }

    public string GetSelectedAnimation()
    {

        return selectedAnimation;
    }
}