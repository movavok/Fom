using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource musicAudio;
    private AudioClip clip;

    private bool isTriggered = false;

    private void Start()
    {
        clip = musicAudio.clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isTriggered == false)
        {
            isTriggered = true;
            musicAudio.PlayOneShot(clip);
        }
    }
}
