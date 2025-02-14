using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class PLayerInput : MonoBehaviour
{
    public Animator anim;

    public float moveSpeed;
    public float fuerzaRebote = 10f;

    private Rigidbody2D rb;

    private float x;
    private float y;

    private Vector2 input;
    private bool moving;
    private bool isAttacking;
    private bool recibeDanio;

    public int vidas = 4;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetInput();
        Animate();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(x * moveSpeed, y * moveSpeed); 
    }

    private void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        x = Input.GetAxisRaw("Vertical");

        input = new Vector2 (x, y);
        input.Normalize();
    }

    private void Animate()
    {
        if(input.magnitude > 0.1f || input.magnitude < -0.1f)
        {
            moving = true;
        }
        else
        {
            moving= false; 
        }

        if (moving)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);
        }

        if (Input.GetKeyDown(KeyCode.Z) && !isAttacking)
        {
            IsAttacking();
        }

        anim.SetBool("Moving", moving);
        anim.SetBool("IsAttacking", isAttacking);
        anim.SetBool("recibeDanio", recibeDanio);
    }

    public void IsAttacking()
    {
        isAttacking = true;
    }

    public void DesactiveAttack()
    {
        isAttacking= false;
    }

    public void RecibeDanio(Vector2 direccion, int cantDanio)
    {
        if (!recibeDanio)
        {
            recibeDanio = true;
            Vector2 rebote = new Vector2(transform.position.x - direccion.x, 1). normalized;
            rb.AddForce(rebote * fuerzaRebote, ForceMode2D.Impulse);
        }

    }
    
    public void DesactivaDanio()
    {
        recibeDanio= false;
    }

}
