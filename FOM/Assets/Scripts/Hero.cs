using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int lives = 5;
    [SerializeField] private float jumpForce = 7f;
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
<<<<<<< HEAD
=======

>>>>>>> parent of 85bb329 (на просмотр)
    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Run()
    {
        if (isGrounded) State = States.Run;
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
<<<<<<< HEAD
        
    }
    void FixedUpdate()
    {
        CheckGround();
        if (Input.GetButton("Horizontal"))
        {
            if (speed < 0)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
        }
    }
    void Update()
    {
=======
        sprite.flipX = dir.x < 0.0f;
    }
    private void FixedUpdate()
    {
        CheckGround();
    }
    private void Update()
    {
>>>>>>> parent of 85bb329 (на просмотр)
        if (isGrounded) State = States.Idle;
        if (Input.GetButton("Horizontal"))
            Run();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();
    }
<<<<<<< HEAD
    void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
    void CheckGround()
=======
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
    private void CheckGround()
>>>>>>> parent of 85bb329 (на просмотр)
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        isGrounded = collider.Length > 1;

        if (!isGrounded) State = States.Jump;
    }
}

public enum States
{
    Idle,
    Run,
    Jump
}


