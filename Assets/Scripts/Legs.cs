using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Legs : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;

    public float requiredTime = 1f;
    public float angleThreshold = 15f;

    void Start()
    {
        StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {
        yield return WaitForLookDown(requiredTime);
        audio1.Play();

        yield return WaitForLookUp(requiredTime);

        yield return WaitForLookDown(requiredTime);
        audio2.Play();

        yield return WaitForLookUp(requiredTime);

        yield return WaitForLookDown(requiredTime);
        audio3.Play();

        yield return WaitForLookUp(requiredTime);

        yield return WaitForLookDown(requiredTime);
        SceneManager.LoadScene("The Leg Ending");
    }

    IEnumerator WaitForLookDown(float duration)
    {
        float timer = 0f;

        while (timer < duration)
        {
            if (IsLookingDown())
                timer += Time.deltaTime;
            else
                timer = 0f;

            yield return null;
        }
    }

    IEnumerator WaitForLookUp(float duration)
    {
        float timer = 0f;

        while (timer < duration)
        {
            if (IsLookingUp())
                timer += Time.deltaTime;
            else
                timer = 0f;

            yield return null;
        }
    }

    bool IsLookingDown()
    {
        float x = transform.eulerAngles.x;
        if (x > 180f) x -= 360f;
        return Mathf.Abs(x - 90f) < angleThreshold;
    }

    bool IsLookingUp()
    {
        float x = transform.eulerAngles.x;
        if (x > 180f) x -= 360f;
        return Mathf.Abs(x) < angleThreshold;
    }
}
