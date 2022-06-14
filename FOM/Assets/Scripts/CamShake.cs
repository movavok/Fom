using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    public Animator camShake;

    public void Shake()
    {
        camShake.SetTrigger("shake");
    }
}
