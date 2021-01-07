using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Task : MonoBehaviour
{
    public List<Goal> Goals { get; set; } = new List<Goal>();
    public string description { get; set; }
    public int restPointsReward { get; set; }
    public bool Completed { get; set; }

    public Player player;

    private void Awake()
    {
        player = transform.parent.gameObject.GetComponent<Player>();
    }
    //checks if all goals are completed
    public void CheckGoals()
    {
        Completed = Goals.All(g => g.isCompleted);
    }

    public void GiveReward()
    {
        player.ReceiveRestPoints(restPointsReward);
        //for every 30s spent on a task recieve 5 points
    }

    
}
