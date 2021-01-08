using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TaskGoal
{
     public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool grab = false;

   public bool isReached()
    {
        bool goalReached = false;
        if(currentAmount >= requiredAmount && goalType == GoalType.Gathering || goalType == GoalType.Kill)
        {
            goalReached = true;
            return goalReached;
        }

        if (grab && goalType == GoalType.Grab)
        {
            goalReached = true;
            return goalReached;
        }

        return goalReached;
    }

    public void EnemyKilled()
    {
        if(goalType == GoalType.Kill)
        currentAmount++;
    }

    public void ItemsCollected()
    {
        if (goalType == GoalType.Gathering)
            currentAmount++;
    }

    public void ItemGrabbed()
    {
        if (goalType == GoalType.Grab) 
        {
            currentAmount++;
        };
             
    }
}

public enum GoalType
{
    Kill,
    Gathering,
    Grab
}
