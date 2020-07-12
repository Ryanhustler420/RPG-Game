using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Internal;

public class Mover : MonoBehaviour
{
    /* fields for this class */
    [SerializeField]    Transform       target;
    private             NavMeshAgent    navMesh;

    void Awake()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if(hasHit)
        {
            navMesh.destination = hit.point;
        }
    }
}
