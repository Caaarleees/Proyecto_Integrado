using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillAl : MonoBehaviour
{


    [SerializeField]
    private int _killscore;


    private KillsCounter _killsCounter;


        private void Awake()
    {
        _killsCounter = FindAnyObjectByType<KillsCounter>();
            
    }

    public void AllocateKills()
    {
        _killsCounter.AddKills(_killscore);
    }


}
