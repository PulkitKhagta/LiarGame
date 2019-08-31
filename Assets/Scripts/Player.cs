using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int  health = 10;
    public float speed;
    public Text healthDisplay;

    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        healthDisplay.text = "Health : " + health;

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if(moveInput.x == 0 && moveInput.y == 0)
        {
            anim.SetBool("IsWalking", false);
        }
        else
        {
            anim.SetBool("IsWalking", true);
        }

        /*if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("HasWon", true);
        }
        else
        {
            anim.SetBool("HasWon", false);
        }*/
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
