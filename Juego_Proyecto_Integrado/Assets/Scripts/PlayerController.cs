using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    //Variables de referencia 
    private Rigidbody2D playerRb;
    private Animator anim;
    private float horizontalInput;
    private float verticalInput;

    //Varibales de estadísticas del player
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
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
    }

}
