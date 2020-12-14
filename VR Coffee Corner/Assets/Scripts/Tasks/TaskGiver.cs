using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskGiver : MonoBehaviour
{
    public List<Task> tasks = new List<Task>();

    public Task task;

    public Player player;

    public GameObject taskWindow;
    public Text descriptionText;
    public Text restPointsText;
    public Text energyPointsText;

/*    public void OpenTaskWindow()
    {
        if (!taskWindow.activeSelf) { taskWindow.SetActive(true); }
        else if(taskWindow.activeSelf) { taskWindow.SetActive(false); }


        descriptionText.text = task.description;
        restPointsText.text = task.restPointsReward.ToString();
        energyPointsText.text = task.energyPointsReward.ToString();
    }

    public void AcceptTasks()
    {
        taskWindow.SetActive(false);
        task.isActive = true;

        player.task = task;
    }

    public void changeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }*/
}
