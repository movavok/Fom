using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    Vector3 posEnd, posSmoth;
    
    private void Update()
    {
        posEnd = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        
        posSmoth = Vector3.Lerp(transform.position, posEnd, 0.125f);
        
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    
        transform.position = posSmoth;
    }
}
