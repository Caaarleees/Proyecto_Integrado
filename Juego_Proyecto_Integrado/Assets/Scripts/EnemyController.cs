using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Enemy Move Parameters")]
    [SerializeField] float speed;
    [SerializeField] float limitX = -10;

    [Header("General References")]
    [SerializeField] GameObject enemyBody;
    [SerializeField] BoxCollider2D enemyCol;
    [SerializeField] Animator enemyAnim;

    private void Awake()
    {
        enemyCol = GetComponent<BoxCollider2D>();
        enemyAnim = enemyBody.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
