using UnityEngine;

public class EndingLightsManager : MonoBehaviour
{
    public ProgressManager progressManager;

    public GameObject theFoundLegsParent;
    public GameObject realEndingLightsParent;
    public GameObject legEndingLightsParent;

    void Start()
    {
        if (progressManager == null)
        {
            progressManager = Object.FindFirstObjectByType<ProgressManager>();
        }

        UpdateLights(theFoundLegsParent, "The Found Legs");
        UpdateLights(realEndingLightsParent, "The Real Ending");
        UpdateLights(legEndingLightsParent, "The Leg Ending");
    }

    void UpdateLights(GameObject parent, string endingName)
    {
        if (parent == null) return;
        if (progressManager.HasCompletedEnding(endingName))
        {
            Light[] lights = parent.GetComponentsInChildren<Light>();
            foreach (Light light in lights)
            {
                light.color = Color.white;
            }
        }
    }
}
