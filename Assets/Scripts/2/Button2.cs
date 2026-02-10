using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2 : MonoBehaviour
{
    void OnClicked()
    {
        Debug.Log("end of 2 clicked");
        SceneManager.LoadScene("Level 3");
    }
}
