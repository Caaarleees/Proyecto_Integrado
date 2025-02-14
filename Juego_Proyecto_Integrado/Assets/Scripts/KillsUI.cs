using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KillsUI : MonoBehaviour
{
    private TMP_Text _killsText;

    private void Awake()
    {
        _killsText = GetComponent<TMP_Text>();
    }

    public void UpdateKills(KillsCounter killsCounter)
    {
        _killsText.text = $"Kills: {killsCounter.Kills}"; 
    }
    
  

}
