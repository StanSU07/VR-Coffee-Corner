using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PoolTask : Task
{
    public int timeAmount = 5;

    public TMP_Text descriptionText;
    public TMP_Text rewardText;
    public GameObject check;

    void Start()
    {
        descriptionText = GameObject.Find("Task2").GetComponent<TMP_Text>();
        rewardText = GameObject.Find("Reward2").GetComponent<TMP_Text>();
        check = GameObject.Find("PChecked");

        description = "Go Swimming in the pool for " + timeAmount.ToString() + " in the Zen Garden";
        restPointsReward = 20;
        check.GetComponent<SpriteRenderer>().enabled = false;

        Goals.Add(new TimeGoal(this, "pool", "Go Swimming in the pool in the Zen Garden",false, false, 0, timeAmount, 0));

        Goals.ForEach(g => g.Init());
    }

    private void Update()
    {
       
            descriptionText.text = description;
            rewardText.text = restPointsReward.ToString() + " pnt";

            if (Completed)
            {
            check.GetComponent<SpriteRenderer>().enabled = true;
            }

    }
}
