using UnityEngine;
using UnityEngine.SceneManagement;

public class Button3Leg : MonoBehaviour
{
    private ProgressManager progressManager;
    void Start()
    {
        progressManager = Object.FindFirstObjectByType<ProgressManager>();
    }
    void OnClicked()
    {
        progressManager.CompleteEnding("The Found Legs");
        SceneManager.LoadScene("Home");
    }
}
