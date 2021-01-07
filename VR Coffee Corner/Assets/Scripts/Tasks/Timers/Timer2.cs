using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer2
{
    public static string id = "pool";

    public static float timer = 0;
    public static float seconds;
    static bool start;

    static public void StartTimer()
    {
        start = true;

        if (start)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);

            Debug.Log(id + ": " + (int)seconds);
        }
    }

    static public void ResetTimer()
    {
        start = false;
        timer = 0;

    }
}
