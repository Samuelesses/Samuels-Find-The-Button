using UnityEngine;
using UnityEngine.SceneManagement;

public class Button3 : MonoBehaviour
{
    void OnClicked()
    {
        Debug.Log("end of 3 clicked");
        SceneManager.LoadScene("Home");
    }
}
