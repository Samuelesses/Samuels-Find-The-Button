using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Sequence2 : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public GameObject MainButton;

    void Start()
    {
        StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(5f);
        Subtitle.text = "Okay Greg, this is your first challenge.";

        yield return new WaitForSeconds(4f);
        Subtitle.text = "All you have to do is find and press the button, easy enough?";

        yield return new WaitForSeconds(30);
        Subtitle.text = "Greg, you've been searching for a while? No luck? Let me have a look..";

        yield return new WaitForSeconds(6f);
        Subtitle.text = "Ahh Greg, you won't believe this! I forgot to put the button in... Let's try again.";
        MainButton.SetActive(true);
    }
}