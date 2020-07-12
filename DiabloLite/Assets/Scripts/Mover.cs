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

    void Awake()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMesh.destination = target.position;
        // navMesh.SetDestination(target.position); // same
    }
}
