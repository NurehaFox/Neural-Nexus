using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    [HideInInspector]
    public float speedMod = 1f;
    private int currentPoint;
    private bool reachedEnd;

    public float timeBetweenAttacks, damagePerAttack;
    private float attackCounter;

    private Portal theCastle;

    private int selectedAttackPoint;

    public bool isFlying;
    public float flyHeight;

    // Start is called before the first frame update
    void Start()
    {


        if (theCastle == null)
        {
            theCastle = FindObjectOfType<Portal>();
        }

        attackCounter = timeBetweenAttacks;

    }

     

}
