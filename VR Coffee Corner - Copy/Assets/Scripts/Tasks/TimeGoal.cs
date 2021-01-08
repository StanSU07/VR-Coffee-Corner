using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGoal : Goal
{

    public string PlaceID { get; set; }
    public TimeGoal(Task task, string placeID, string description, bool completed, bool insideTrigger, int currentAmount, int requiredAmount, int extraAmount)
    {
        this.Task = task;
        this.PlaceID = placeID;
        this.Description = description;
        this.isCompleted = completed;
        this.insideTrigger = insideTrigger;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
        this.ExtraAmount = extraAmount;
    }

    //listen for an eventListener when seeing how much time is spent on a task
    public override void Init()
    {
        base.Init();

        Events.current.onPlaceEntered += TimeDid;
        Events.current.onPlaceExited += TimeDidnt;
    }

   

    //check to see what kind of place it is you're doing the task in
    //function is called when u enter a place id
    public void TimeDid(string place)
    {
        if (place == this.PlaceID)
        {
            insideTrigger = true;
            if(place == Timer1.id)
            {
                this.CurrentAmount = (int)Timer1.seconds;
                Debug.Log(place + ": " + (int)Timer1.seconds);
            }
            if(place == Timer2.id)
            {
                this.CurrentAmount = (int)Timer2.seconds;
                Debug.Log(place + ": " + (int)Timer2.seconds);
            }

            Evaluate();
        }
    }

    //function is called when u exit a place id
    public void TimeDidnt(string place)
    {
        if (place == this.PlaceID)
        {
            insideTrigger = false;
        }
    }

}
