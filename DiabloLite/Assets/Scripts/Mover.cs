using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Internal;

public class Mover : MonoBehaviour
{
    /* fields for this class */
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
        UpdateAnimator();
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

    private void UpdateAnimator()
    {
        // for turning the charcter into forward direction
        // tweek from navMess Agent from inspector

        // NOTE: velocity means speed and direction
        // navMash gives use speed and direction but it won't gives us when turning command like take left or right at this moment.
        // so we need to convert that vactor3 into local vector3

        // want to get vector3 from navMash which has already direction and speed.
        Vector3 velocity = navMesh.velocity;
        // convert that to local velocity, which helps our animator blend tree to understand where the speed decreases.
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        // get the forward or (z) direction speed,
        float speed = localVelocity.z;
        // updating speed every frame and setting to blend tree
        GetComponent<Animator>().SetFloat("forwardSpeed", speed);
    }

}
