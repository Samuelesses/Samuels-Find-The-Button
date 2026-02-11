using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Sequence3 : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public GameObject MainButton;
    public GameObject Player;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public AudioSource audio8;
    public AudioSource audio9;

    void Start()
    {
        StartCoroutine(PlaySequence());
    }

    IEnumerator WaitOrFall(float seconds)
    {
        float endTime = Time.time + seconds;
        yield return new WaitUntil(() => Time.time >= endTime || Player.transform.position.y < -22);
    }

    void EndWithFoundMessage()
    {
        Subtitle.text = "Greg! You found it! This is amazing! Who knew your body wouldn't be hurt from such an impactful fall? ";
        audio9.Play();
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(5f);
        Subtitle.text = "Sorry about that last one.";
        audio1.Play();

        yield return new WaitForSeconds(4f);
        Subtitle.text = "Ok Greg, this one is a little dangerous.";
        audio2.Play();

        yield return new WaitForSeconds(7f);
        Subtitle.text = "If you fall, I don't know what will happen.";
        audio3.Play();

        yield return new WaitForSeconds(30f);
        Subtitle.text = "Wow Greg, this button doesn't seem to be anywhere. I don't think I hid it again, did I?";
        audio4.Play();

        yield return new WaitForSeconds(15f);
        Subtitle.text = "Just checked, nope, I didn't, keep looking.";
        audio5.Play();

        yield return new WaitForSeconds(30f);
        Subtitle.text = "Greg, you have built some patience, just find the button.";
        audio6.Play();

        yield return new WaitForSeconds(20f);
        Subtitle.text = "Oh, Greg, you're still searching. Could you maybe, find the button!";
        audio7.Play();

        yield return new WaitForSeconds(20f);
        Subtitle.text = "Greg, this is the last thing I will say before you're on your own. Saying you've looked everywhere, have you tried, looking down...";
        audio8.Play();
    }
}