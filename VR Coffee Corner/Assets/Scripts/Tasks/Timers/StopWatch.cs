using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StopWatch : MonoBehaviour
{
    public string id;

    public float timer;
     float minutes;
     float seconds;
     float hours;

     bool start;

    [SerializeField]
     private Text stopwatchText;

    // Start is called before the first frame update
     void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
     void Update()
    {
        StopwatchCalcul();
    }

    public  void StopwatchCalcul()
    {
        if (start)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
            minutes = (int)((timer / 60) % 60);
            hours = (int)(timer / 3600);

            stopwatchText.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }

    }

     public void StartTimer()
    {
        start = true;
    }

     public void PauseTimer()
    {
        start = false;
    }

     public void ResetTimer()
    {
        start = false;
        timer = 0;
        stopwatchText.text = "00:00:00";

    }
}
