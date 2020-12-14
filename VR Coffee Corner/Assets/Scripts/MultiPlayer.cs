using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayer : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;
    public Animator anim;
    
    private int waypointIndex;
    private float distance; 


    void Start()
    {
        waypointIndex=0;
        transform.LookAt(waypoints[waypointIndex].position);
        anim= GetComponent<Animator>();
    }

    
    void Update()
    {
        distance=Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(distance<1f)
        {
            IncreaseIndex();
        }
        Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }

    void IncreaseIndex()
    {
        waypointIndex++;

        if(waypointIndex>=waypoints.Length)
        {
            waypointIndex=0;
        }
        transform.LookAt(waypoints[waypointIndex].position);

    }
}

