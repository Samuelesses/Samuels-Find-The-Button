using UnityEngine;
using System.Collections;
using TMPro;

public class SequenceManager : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public AudioSource audio1;
    public AudioSource audio2;
    public GameObject MicWarning;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public GameObject MainLight;
    public AudioSource audio7;
    public AudioSource audio8;

    void Start()
    {
        StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(5f);
        audio1.Play();
        Subtitle.text = "Welcome to the tutorial, lets do some basics!";

        yield return new WaitForSeconds(4f);
        audio2.Play();
        Subtitle.text = "First off, let us know your name. So we can keep it, personal.";

        yield return new WaitForSeconds(5f);
        MicWarning.SetActive(true);

        yield return new WaitForSeconds(6f);
        audio3.Play();
        Subtitle.text = "I've just remembered. I don't really care.";

        yield return new WaitForSeconds(3f);
        MicWarning.SetActive(false);

        yield return new WaitForSeconds(1f);
        audio4.Play();
        Subtitle.text = "I'll just call you Greg, is that okay with you?- Ahh I forgot, you don't speak.";

        yield return new WaitForSeconds(6f);
        audio5.Play();
        Subtitle.text = "Let's just go with Greg.";

        yield return new WaitForSeconds(4f);
        audio6.Play();
        Subtitle.text = "Okay Greg, let's get some lights on in here.";

        yield return new WaitForSeconds(3f);
        MainLight.SetActive(true);

        yield return new WaitForSeconds(1f);
        audio7.Play();
        Subtitle.text = "Now you may be wondering, where is this button?";

        yield return new WaitForSeconds(5f);
        audio8.Play();
        Subtitle.text = "And if you are... You are impatient. And need to wait longer.";
        yield return new WaitForSeconds(5f);
        Subtitle.text = "Press the green button if you were wondering that, no lies.";
    }
}