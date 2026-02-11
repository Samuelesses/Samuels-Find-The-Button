using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Sequence2 : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public GameObject MainButton;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;

    void Start()
    {
        StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(3f);
        Subtitle.text = "Okay Greg, this is your first challenge.";
        audio1.Play();

        yield return new WaitForSeconds(5f);
        Subtitle.text = "All you have to do is find and press the button, easy enough?";
        audio2.Play();

        yield return new WaitForSeconds(5f);
        Subtitle.text = "";

        yield return new WaitForSeconds(25f);
        Subtitle.text = "Greg, come on, we can look all day but you've been looking forever?";
        audio3.Play();

        yield return new WaitForSeconds(6f);
        Subtitle.text = "No luck? Let me have a look..";

        yield return new WaitForSeconds(5f);
        Subtitle.text = "Ahh Greg, you won't believe this! I forgot to put the button in... Let's try again.";
        audio4.Play();

        yield return new WaitForSeconds(10f);
        Subtitle.text = "";
        MainButton.SetActive(true);
    }
}