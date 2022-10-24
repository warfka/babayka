using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource playsound;
    public bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
            if (isTriggered == false)
            {
                isTriggered = true;
                playsound.Play();
                StartCoroutine(PreventSoundToStack());
            }
    }
    IEnumerator PreventSoundToStack()
    {
        yield return new WaitForSeconds(playsound.clip.length + 1f);
        isTriggered = false;
    }
}
