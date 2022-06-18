using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance; 
    
    private Transform target;
    public Transform player;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(player);
        
        if (Vector2.Distance(transform.position, target.position)> stoppingDistance )
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            
        }
       
        
    }
}
