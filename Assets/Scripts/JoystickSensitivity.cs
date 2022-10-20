using UnityEngine;
using UnityEngine.UI;

public class JoystickSensitivity : MonoBehaviour
{
    [SerializeField]
    private float Multiplier = 1f;
    [SerializeField] [Range(1, 20)]
    private byte StepsNumber = 10;
    private void Start()
    {
        Scrollbar s = GetComponent<Scrollbar>();
        s.numberOfSteps = StepsNumber + 1;
        s.value = (float)(PlayerPrefs.GetFloat("Sensitivity") - Multiplier) / StepsNumber / Multiplier;
    }
    public void SetupSensitivity()//int s)
    {
        Scrollbar s = GetComponent<Scrollbar>();
        PlayerPrefs.SetFloat("Sensitivity", s.value * Multiplier * StepsNumber + Multiplier);
        //Debug.Log(PlayerPrefs.GetFloat("Sensitivity"));
    }
}
