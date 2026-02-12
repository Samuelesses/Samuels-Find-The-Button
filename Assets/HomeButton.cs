using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    void OnClicked()
    {
        SceneManager.LoadScene("Level 1");
    }
}
