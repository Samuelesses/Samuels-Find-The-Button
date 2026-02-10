using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Sequence3 : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public GameObject MainButton;
    public GameObject Player;

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
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(5f);
        Subtitle.text = "Sorry about that last one.";

        yield return new WaitForSeconds(4f);
        Subtitle.text = "Ok Greg, this one is a little dangerous.";

        yield return new WaitForSeconds(5f);
        Subtitle.text = "If you fall, I don't know what will happen.";

        yield return new WaitForSeconds(15f);
        Subtitle.text = "Wow Greg, this button doesn't seem to be anywhere. I don't think I hid it again, did I?";

        yield return new WaitForSeconds(5f);
        Subtitle.text = "Just checked, nope, I didn't, keep looking.";

        yield return new WaitForSeconds(15f);
        Subtitle.text = "Greg, you have built some patience, just find the button.";

        yield return new WaitForSeconds(15f);
        Subtitle.text = "Oh, Greg, you're still searching. Could you maybe, find the button!";

        yield return new WaitForSeconds(15f);
        Subtitle.text = "Greg, this is the last thing I will say before you're on your own. Saying you've looked everywhere, have you tried, looking down...";
    }
}