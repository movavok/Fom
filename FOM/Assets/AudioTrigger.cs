using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSourse musicAudio;
    private AudioClip clip;
    
    private bool isTriggered = false;
    
    private void Start()
    {
       clip = UWU Sound.clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" || other.tag == "Player1")
        {
            if(isTriggered == false)
            {
                isTriggered = true;
                musicAudio.PlayOneShot(clip);
            }
        }
    }
}
