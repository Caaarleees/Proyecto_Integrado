using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void BotonPlay()
    {
        SceneManager.LoadScene(1);


    }


    public void BotonExit()
    {
        Debug.Log("Salir del juego");
        Application.Quit();
    }

    public void BotonExit2()
    {
        SceneManager.LoadScene(0);
    }






}




