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
    

    void Awake()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
       
        timeText.text=time;
        dateText.text=date; 
       
        
  
    }

    public void SetLocationZenGarden(){
        locationText.SetText("Zen Garden");
    }

    public void SetLocationMainLobby(){
        locationText.SetText("Main Lobby");
    }

     public void SetLocationArcade(){
        locationText.SetText("Arcade room");
    }


    void Update(){

        gameTimer +=Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer/60) % 60;
        int hours = (int)(gameTimer/3600) % 24;
        string timerString = string.Format("{0:0}:{1:00}:{2:00}",hours, minutes, seconds);
        
        timerText.text=timerString;      
}
    }
