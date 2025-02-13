using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    //Variables de referencia 
    private Rigidbody2D playerRb;
    private BoxCollider2D boxCollider2D;
    private Animator anim;
    private float horizontalInput;
    private float verticalInput;
    private bool isFacingRight = true;

    //Varibales de estadísticas del player
    public float speed;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontalInput = UnityEngine.Input.GetAxis("Horizontal");
        playerRb.velocity = new Vector2(horizontalInput * speed, playerRb.velocity.y);
        verticalInput = UnityEngine.Input.GetAxis("Vertical");
        playerRb.velocity = new Vector2(verticalInput * speed, playerRb.velocity.x);
        if (horizontalInput != 0f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        //Flip: si el valor del input es diferente a 0
        if (horizontalInput > 0)
        {
            anim.SetBool("Run", true);
            if (!isFacingRight)
            {
                Flip();
            }
        }
        if (horizontalInput < 0)
        {
            anim.SetBool("Run", true);
            if (isFacingRight)
            {
                Flip();
            }
        }
        if (verticalInput > 0)
        {
            anim.SetBool("Run", true);
            if (!isFacingRight)
            {
                Flip();
            }
        }
        if (verticalInput < 0)
        {
            anim.SetBool("Run", true);
            if (isFacingRight)
            {
                Flip();
            }
        }
        if (horizontalInput == 0)
        {
            anim.SetBool("Run", false);
        }
        if (verticalInput == 0)
        {
            anim.SetBool("Run", false);
        }
    }

 

 
    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
        isFacingRight = !isFacingRight;
    }
}
