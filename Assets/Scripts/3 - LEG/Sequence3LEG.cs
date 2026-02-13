using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Sequence3LEG : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public GameObject Hint;
    public GameObject Normal;
    public GameObject Player;
    public GameObject PlayerLegs;
    public GameObject Legs;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public float triggerDistance = 10f;
    private ProgressManager progressManager;

    private bool LegPressed = false;
    private bool CanClick = false;

    void Start()
    {
        progressManager = Object.FindFirstObjectByType<ProgressManager>();

        bool legEndingCompleted = progressManager.HasCompletedEnding("The Leg Ending");
        bool foundLegsCompleted = progressManager.HasCompletedEnding("The Found Legs");

        if (!(legEndingCompleted && !foundLegsCompleted))
        {
            gameObject.SetActive(false);
        }
    }

    public void OnLegPressed()
    {
        if (!CanClick) return;

        LegPressed = true;
    }

    bool triggered = false;
    void Update()
    {
        if (triggered) return;

        float distance = Vector3.Distance(Player.transform.position, Legs.transform.position);

        if (distance <= triggerDistance)
        {
            triggered = true;
            StartCoroutine(PlaySequence());
        }
    }

    IEnumerator WaitOrFall(float seconds)
    {
        float endTime = Time.time + seconds;
        yield return new WaitUntil(() => Time.time >= endTime || Player.transform.position.y < -22);
    }

    IEnumerator PlaySequence()
    {
        Normal.SetActive(false);
        Subtitle.text = "Wait a minute, Greg, are those fucking legs?";
        audio1.Play();

        yield return new WaitForSeconds(6f);
        Subtitle.text = "How have you- This isn't meant to be possible!";
        audio2.Play();

        yield return new WaitForSeconds(5.5f);
        Subtitle.text = "Well you're gonna have to turn arround an exit. NOW!";
        audio3.Play();

        yield return new WaitForSeconds(5f);
        Hint.SetActive(true);
        CanClick = true;

        yield return new WaitUntil(() => LegPressed);
        Hint.SetActive(false);
        Subtitle.text = "Greg what are you doing? Don't touch those!";
        audio4.Play();
        Legs.SetActive(false);
        PlayerLegs.SetActive(true);

        yield return new WaitForSeconds(6.5f);
        Subtitle.text = "Thats it, I'm taking control as you're so disobedient..";
        audio5.Play();

        yield return new WaitForSeconds(5f);
        Player.transform.position = new Vector3(Player.transform.position.x, -5f, Player.transform.position.z);

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("The Found Legs");



    }
}