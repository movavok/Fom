using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] float speed = 7f;
    [SerializeField] int lives = 5;
    [SerializeField] float jumpForce = 10f;
    bool Ground = false;

    Rigidbody2D rb;
    SpriteRenderer sprite;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
        if (Ground && Input.GetButton("Jump"))
            Jump();
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    void Grounded()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 1f);
        Ground = collider.Length > 1;
    }

    void FixedUpdate()
    {
        Grounded();
    }
}