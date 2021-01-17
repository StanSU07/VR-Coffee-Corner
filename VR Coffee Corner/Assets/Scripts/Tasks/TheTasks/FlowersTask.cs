using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FlowersTask : Task
{
    public int amount = 2;

    public TMP_Text descriptionText;
    public TMP_Text rewardText;
    public GameObject check;

    void Start()
    {
        descriptionText = GameObject.Find("Task3").GetComponent<TMP_Text>();
        rewardText = GameObject.Find("Reward3").GetComponent<TMP_Text>();
        check = GameObject.Find("FChecked");

        description = "Pick " + amount.ToString() + " Flowers in the Zen Garden";
        restPointsReward = 15;
        check.SetActive(false);

        Goals.Add(new CollectingGoal(this, "flower", "Pick Flowers in the Zen Garden", false, 0, amount, 0));
        Goals.ForEach(g => g.Init());

    }

    private void Update()
    {
            descriptionText.text = description;
            rewardText.text = restPointsReward.ToString() + " pnt";

            if (Completed)
            {
                check.SetActive(true);
            }
    }
}
