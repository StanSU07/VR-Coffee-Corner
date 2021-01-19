using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class YogaTask :  Task
{ 
    public int timeAmount = 10;

    public TMP_Text descriptionText;
    public TMP_Text rewardText;
    public GameObject check;

    void Start()
    {
        descriptionText = GameObject.Find("Task1").GetComponent<TMP_Text>();
        rewardText = GameObject.Find("Reward1").GetComponent<TMP_Text>();
        check = GameObject.Find("YChecked");

        description = "Do Yoga in the Zen Garden for "+ timeAmount.ToString() + " seconds";
        restPointsReward = 10;
        check.GetComponent<SpriteRenderer>().enabled = false;

        Goals.Add(new TimeGoal(this, "yoga", "Do Yoga in the Zen Garden", false, false, 0, timeAmount, 0));
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
