using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed = 7f;
    public float jumpForce = 5f;
    public GameObject woodman;
    public GameObject bober;

    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sr;

    bool isAttacking = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isAttacking)
        {
            isAttacking = true;

            animator.Play("wdmAttack");

            Invoke("ResetAttack", .5f);


        }



        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;


        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05f)
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);


        transform.position += transform.forward * speed * Time.deltaTime;
        sr.flipX = movement < 0 ? true : false;
        Physics2D.IgnoreCollision(woodman.GetComponent<Collider2D>(), bober.GetComponent<Collider2D>());

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            animator.Play("step");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            animator.Play("step");
        }
        else
        {
            animator.Play("NewAnimation");
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.Play("wdmAttack");
        }
        
    }

    void ResetAttack()
    {
        isAttacking = false;
    }
}

