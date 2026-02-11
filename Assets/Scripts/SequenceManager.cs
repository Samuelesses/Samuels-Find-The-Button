using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class SequenceManager : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public GameObject Player;
    public GameObject wasd;
    public AudioSource wasdsound;

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
    public GameObject GreenButton;
    public AudioSource audio9;
    public AudioSource audio10;
    public GameObject MainButton;
    public AudioSource audio11;

    private bool greenButtonPressed = false;
    private bool readyForMainButton = false;
    private bool altScene = false;
    private bool playingAltScene = false;

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
        GreenButton.SetActive(true);

        yield return new WaitForSeconds(7f);

        if (greenButtonPressed)
        {
            Subtitle.text = "";
            yield return new WaitForSeconds(10f);
        }

        audio9.Play();
        Subtitle.text = "Okay great, lets get your legs moving!";
        
        GreenButton.SetActive(false);
        yield return new WaitForSeconds(3f);
        Player.GetComponent<SimpleMove>().movementEnabled = true;
        wasd.SetActive(true);
        wasdsound.Play();
        

        yield return new WaitUntil(() => Mathf.Abs(Player.transform.position.z - 12.32f) > 0.1f);

        yield return new WaitForSeconds(3f);
        wasd.SetActive(false);
        audio10.Play();
        Subtitle.text = "Nice work, now here is your first button, it works like any other button would,";
        MainButton.SetActive(true);

        yield return new WaitForSeconds(6f);
        Subtitle.text = "but upon finidng, you move onto the next level. Find all buttons to win!";
        
        yield return new WaitForSeconds(6f);

        Subtitle.text = "Simple Enough?";

        yield return new WaitForSeconds(3f);
        audio11.Play();
        readyForMainButton = true;
        Subtitle.text = "Now press the button when you're ready!";

    }

    public void OnGreenButtonPressed()
    {
        greenButtonPressed = true;
    }

    public void OnRedButtonPressed()
    {
        greenButtonPressed = true;
        SceneManager.LoadScene("Level 2");
    }

    public void OnMainButtonPressed()
    {
        if (playingAltScene)
        {
            return;
        }

        if (!readyForMainButton && !altScene)
        {
            StartCoroutine(PlayAltScene());
        }
        else if (readyForMainButton || altScene)
        {
            SceneManager.LoadScene("Level 2");
        }
    }

    IEnumerator PlayAltScene()
    {
        altScene = true;
        playingAltScene = true;
        audio1.Play();
        Subtitle.text = "I said when you're READY!";
        
        yield return new WaitForSeconds(3f);
        
        playingAltScene = false;
    }
}