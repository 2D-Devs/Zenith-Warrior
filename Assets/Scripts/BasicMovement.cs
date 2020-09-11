using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public static BasicMovement bm;

    public Animator animator;

    public float moveSpeed = 5f;
    public Vector2 movement;
    public Rigidbody2D rb;

    public float hf = 0.0f;
    public float vf = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();

    }


    // Update is called once per frame
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;

        hf = movement.x > 0.01f ? movement.x : movement.x < -0.01f ? 1 : 0;
        vf = movement.y > 0.01f ? movement.y : movement.y < -0.01f ? 1 : 0;

        if (movement.x < -0.01f)
        {
            animator.SetBool("Is_Moving_Side", true);
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("Is_Moving_Side", true);
        }

        if (movement.x == 0)
        {
            animator.SetBool("Is_Moving_Side", false);
        }


        animator.SetFloat("Horizontal", hf);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", vf);


    }

    private void FixedUpdate()
    {
        float speed = Input.GetKey(KeyCode.LeftShift) ? 0.45f : 0.25f;
        rb.MovePosition(rb.position + movement * moveSpeed * (Time.fixedDeltaTime * speed));
    }

}