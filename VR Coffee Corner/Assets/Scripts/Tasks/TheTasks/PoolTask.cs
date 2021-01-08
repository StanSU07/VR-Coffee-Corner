using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PoolTask : Task
{
    public int timeAmount = 5;

    public Text descriptionText;
    public Text rewardText;
    public GameObject check;
    public GameObject TaskWindow;

    void Start()
    {
        TaskWindow = GameObject.Find("TasksWindow");
        descriptionText = GameObject.Find("PDescription").GetComponent<Text>();
        rewardText = GameObject.Find("PRestPointsReward").GetComponent<Text>();
        check = GameObject.Find("PChecked");

        description = "Go Swimming in the pool for " + timeAmount.ToString() + " in the Zen Garden";
        restPointsReward = 20;
        check.SetActive(false);

        Goals.Add(new TimeGoal(this, "pool", "Go Swimming in the pool in the Zen Garden",false, false, 0, timeAmount, 0));

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
