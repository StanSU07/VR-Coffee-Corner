using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FlowersTask : Task
{
    public int amount = 2;


    public Text descriptionText;
    public Text rewardText;
    public GameObject check;
    public GameObject TaskWindow;

    void Start()
    {
        TaskWindow = GameObject.Find("TasksWindow");
        descriptionText = GameObject.Find("FDescription").GetComponent<Text>();
        rewardText = GameObject.Find("FRestPointsReward").GetComponent<Text>();
        check = GameObject.Find("FChecked");

        description = "Pick " + amount.ToString() + " Flowers in the Zen Garden";
        restPointsReward = 15;
        check.SetActive(false);

        Goals.Add(new CollectingGoal(this, "flower", "Pick Flowers in the Zen Garden", false, 0, amount, 0));
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
