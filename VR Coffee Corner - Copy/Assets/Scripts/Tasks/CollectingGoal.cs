using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingGoal : Goal
{
    public string ItemID { get; set; }
    public CollectingGoal(Task task, string itemID, string description, bool completed, int currentAmount, int requiredAmount, int extraAmount)
    {
        this.Task = task;
        this.ItemID = itemID;
        this.Description = description;
        this.isCompleted = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
        this.ExtraAmount = extraAmount;
    }

    public override void Init()
    {
        base.Init();
        Events.current.onItemCollected += ItemCollected;
    }

    public void ItemCollected(string item)
    {
        if (item == this.ItemID)
        {
            Debug.Log(this.ItemID);

            insideTrigger = true;
            this.CurrentAmount ++;

            Evaluate();
        }
    }
}
