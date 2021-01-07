using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal 
{
    public Task Task { get; set; }
    public string Description { get; set; }
    public bool isCompleted { get; set; }
    public bool insideTrigger { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }
    public int ExtraAmount { get; set; }

    //a function that will be overriden when a task is being added
    public virtual void Init()
    {
    }

    //function determines if goal is completed
    public void Evaluate()
    {
        Debug.Log("Evaluating");

        if(CurrentAmount >= RequiredAmount)
        {
            Complete();

            ExtraAmount = CurrentAmount - RequiredAmount;

            Debug.Log(ExtraAmount);
        }
    }

    //turns goal to be completed
    public void Complete()
    {
        isCompleted = true;
        Debug.Log("Task Completed");

        Task.CheckGoals();
    }
}
