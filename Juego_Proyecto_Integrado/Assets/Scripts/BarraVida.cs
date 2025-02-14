using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image rellenoBarraVida;
    private PlayerInput playerInput;
    private float vidaMaxima;

    private void Start()
    {
        playerInput = GameObject.Find("Player").GetComponent<PlayerInput>();
        vidaMaxima = playerInput.vida;
    }
    // Update is called once per frame
    void Update()
    {
        rellenoBarraVida.fillAmount = playerInput.vida / vidaMaxima;
    }
}
