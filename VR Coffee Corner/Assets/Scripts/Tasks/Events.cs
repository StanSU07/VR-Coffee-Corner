using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Events : MonoBehaviour
{
    public static Events current;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        current = this;
    }

    
    //this event listens for when you enter a specific place
    public event Action<string> onPlaceEntered;
    public void PlaceTriggerEnter(string id)
    {
        if (onPlaceEntered != null)
        {
            onPlaceEntered(id);
        }
    }

    //this event listens for when you exit a specific place

    public event Action<string> onPlaceExited;
    public void PlaceTriggerExit(string id)
    {
        if (onPlaceExited != null)
        {
            onPlaceExited(id);
        }
    }

    //this event listens for when you collect a specific item
    public event Action<string> onItemCollected;
    public void ItemCollected(string id)
    {
        if (onItemCollected != null)
        {
            onItemCollected(id);
        }
    }

}
