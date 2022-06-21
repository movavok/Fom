using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public GameObject woodman;
    public GameObject bober;
    private Transform target;
    SpriteRenderer sre;





    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sre = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Physics2D.IgnoreCollision(woodman.GetComponent<Collider2D>(), bober.GetComponent<Collider2D>());

        if (target.position.x > transform.position.x)
        {
            sre.flipX = true;
        }
        else 
        {
            sre.flipX = false;
        }
        if (target.position.y > transform.position.y + 4 | target.position.x > transform.position.x + 10 | target.position.x < transform.position.x - 10)
        {
            transform.position = target.position;
            
        }
        if (Vector2.Distance(transform.position, target.position)> stoppingDistance )
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            
        }
        
    }
}
