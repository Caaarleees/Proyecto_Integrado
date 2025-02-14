using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public GameObject portal; // Asigna el portal en el Inspector
    private int killCount = 0;
    private int requiredKills = 20;

    void Start()
    {
        if (portal != null)
            portal.SetActive(false); // Asegura que el portal esté desactivado al inicio
    }

    public void EnemyDefeated()
    {
        killCount++;

        if (killCount >= requiredKills)
        {
            ActivatePortal();
        }
    }

    void ActivatePortal()
    {
        if (portal != null)
        {
            portal.SetActive(true);
            Debug.Log("¡Portal activado!");
        }
    }
}

