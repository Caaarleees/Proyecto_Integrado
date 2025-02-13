using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public PlayerController player;
    public GameObject barra_vida;
    private Animator anim;
    public const string ESTADO_VIDAS = "vidas";




    // Start is called before the first frame update
    void Start()
    {
        anim = barra_vida.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger(ESTADO_VIDAS, player.vidas);
    }
}
