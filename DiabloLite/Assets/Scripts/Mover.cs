using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    /* fields for this class */
    [SerializeField]    Transform       target;
    private             NavMeshAgent    navMesh;
    private             Ray             lastRay;

    void Awake()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            navMesh.destination = target.position;
        }
        Debug.DrawRay(lastRay.origin, lastRay.direction * 100f);
    }
}
