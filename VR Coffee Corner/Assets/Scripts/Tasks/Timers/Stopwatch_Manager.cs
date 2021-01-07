using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopwatch_Manager : MonoBehaviour
{
    //this method accesses all stopwatches scripts functions on different gameobjects
    public void resetStpwMethod()
    {
        foreach (var stopwatch in GetComponentsInChildren<StopWatch>())
        {
            stopwatch.ResetTimer();
        }
    }
}
