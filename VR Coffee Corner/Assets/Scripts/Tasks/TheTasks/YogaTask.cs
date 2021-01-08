using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class YogaTask :  Task
{ 
    public int timeAmount = 10;

    public Text descriptionText;
    public Text rewardText;
    public GameObject check;
    public GameObject TaskWindow;

    void Start()
    {
        TaskWindow = GameObject.Find("TasksWindow");
        descriptionText = GameObject.Find("YDescription").GetComponent<Text>();
        rewardText = GameObject.Find("YRestPointsReward").GetComponent<Text>();
        check = GameObject.Find("YChecked");

        description = "Do Yoga in the Zen Garden for "+ timeAmount.ToString() + " seconds";
        restPointsReward = 10;
        check.SetActive(false);

        Goals.Add(new TimeGoal(this, "yoga", "Do Yoga in the Zen Garden", false, false, 0, timeAmount, 0));
        Goals.ForEach(g => g.Init());
        

    }

    private void Update()
    {
        if (TaskWindow.activeSelf)
        {
            descriptionText.text = description;
            rewardText.text = restPointsReward.ToString() + " rest points";

            if (Completed)
            {
                check.SetActive(true);
            }
        }
    }

}
