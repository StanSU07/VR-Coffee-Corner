using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Task 
{
    public bool isActive;

    public string description;
    public int restPointsReward;
    public int energyPointsReward;

    public void isComplete()
    {
        isActive = false;

        Debug.Log(description + "was completed!");
    }
}
