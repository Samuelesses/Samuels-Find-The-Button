using UnityEngine;
using UnityEngine.SceneManagement;

public class LegPress : MonoBehaviour
{
     public Sequence3LEG legManager;
    void OnClicked()
    {
        legManager.OnLegPressed();
    }
}
