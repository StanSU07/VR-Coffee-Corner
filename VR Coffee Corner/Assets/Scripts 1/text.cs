using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    public TextMeshPro timeText;
    public TextMeshPro dateText;
    public TextMeshPro locationText;
    public TextMeshPro timerText;
    float gameTimer = 0f;
    

    void Start()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        string location=UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        timeText.text=time;
        dateText.text=date; 
        locationText.text = location;
        
  
    }

    void Update(){
        gameTimer+=Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer/60) % 60;
        int hours = (int)(gameTimer/3600) % 24;
        string timerString = string.Format("{0:0}:{1:00}:{2:00}",hours, minutes, seconds);
        
        timerText.text=timerString;      
}
    }
