using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpace : MonoBehaviour
{
    public string id;

    public GameObject StopWatchTimer;
    public GameObject image;
    public TaskGiver taskGiver;


    void Start()
    {
        taskGiver = GameObject.Find("TaskGiverScript").GetComponent<TaskGiver>();
        Timer1.timer = 0;
        Timer2.timer = 0;

        Events.current.onPlaceEntered += StartTimer;
        Events.current.onPlaceExited += PauseTimer;

        StopWatchTimer.GetComponent<StopWatch>().id = this.id;
    }

    private void OnTriggerStay(Collider other)
    {
        Events.current.PlaceTriggerEnter(id);
    }

    private void OnTriggerExit(Collider other)
    {
        Events.current.PlaceTriggerExit(id);
    }

    //This  function starts a specific timer when entering a specific area and tasks are active
    public void StartTimer(string place)
    {
        if (place == this.id && taskGiver.AssignedTask)
        {
            if(this.id == "yoga")
            {
                Debug.Log("this is: " + id);
                if (image.activeSelf)
                {
                    Debug.Log("activate sp timer");
                    StopWatchTimer.GetComponent<StopWatch>().StartTimer();
                }
                else
                {
                    if (StopWatchTimer.GetComponent<StopWatch>().timer > 0)
                    {
                        StopWatchTimer.GetComponent<StopWatch>().PauseTimer();
                    }

                }
            }
            else
            {
                StopWatchTimer.GetComponent<StopWatch>().StartTimer();

            }

            //Yoga Timer
            if (this.id == Timer1.id)
            {
                if (image.activeSelf)
                {
                    Timer1.StartTimer();
                }
            }

            //Pool Timer
            if (this.id == Timer2.id)
            {
                Timer2.StartTimer();
            }
        }
    }

    //this function pauses a specific stopwatch when you exit a specific area
    public void PauseTimer(string place)
    {
        if (place == this.id && taskGiver.AssignedTask)
        {
            StopWatchTimer.GetComponent<StopWatch>().PauseTimer();

        }
    }
}
