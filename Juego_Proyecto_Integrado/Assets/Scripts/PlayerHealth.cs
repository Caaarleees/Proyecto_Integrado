using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHearts = 4;
    private int currentHearts;
    public Image[] hearts;

    // Start is called before the first frame update
    void Start()
    {
        currentHearts = maxHearts;
        UpdateHeartsUI();
    }

    public void TakeDamage()
    {
        if (currentHearts > 0)
        {
            currentHearts--;
            UpdateHeartsUI();
        }
        if (currentHearts == 0)
        {
            Debug.Log("El jugador ha muerto");
        }
    }

    // Update is called once per frame
    void UpdateHeartsUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i < currentHearts;
        }
    }

   
}
