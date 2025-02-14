using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KillsCounter : MonoBehaviour
{
    public UnityEvent OnKillChanged;
    public int Kills {  get; private set; }

    public void AddKills(int amount)
    {
        Kills += amount;
        OnKillChanged.Invoke();
    }
}
