using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal 
{
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }

    public virtual void Init()
    {
        // default init suff
    }

    //function determines if goal is completed
    public void Evaluate()
    {
        if(CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }

    //turns goal to be completed
    public void Complete()
    {
        Completed = true;
    }
}
