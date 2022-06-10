using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed = 7f;
    public float jumpForce = 5f;
    
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;


        if(Input.GetKeyDown(KeyCode.Space))
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
       
    }
}
