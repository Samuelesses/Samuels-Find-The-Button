using UnityEngine;
using UnityEngine.SceneManagement;

public class TheRealEndButton : MonoBehaviour
{
    private ProgressManager progressManager;

    void Start()
    {
        progressManager = Object.FindFirstObjectByType<ProgressManager>();
    }

    void OnClicked()
    {
        progressManager.CompleteEnding("The Real Ending");
        SceneManager.LoadScene("Home");
    }
}
