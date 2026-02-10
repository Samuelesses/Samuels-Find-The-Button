using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class BoxView : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public Camera Camera;
    private BoxCollider boxCollider;
    private bool shown = false;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (boxCollider == null) return;

        float distance = Vector3.Distance(Camera.transform.position, transform.position);
        if (distance > 9f) return;

        Ray ray = new Ray(Camera.transform.position, Camera.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 5f) && hit.collider.gameObject == gameObject && !shown)
        {
            shown = true;
            StartCoroutine(ShowSubtitle());
        }
    }

    private IEnumerator ShowSubtitle()
    {
        Subtitle.text = "Isn't that strange Greg? The developers have";
        yield return new WaitForSeconds(4f);
        Subtitle.text = "lacked the animation skills to make the boxes fall.";
    }
}