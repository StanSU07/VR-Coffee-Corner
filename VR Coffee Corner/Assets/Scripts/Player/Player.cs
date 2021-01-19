using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public int restPoints;

   //public List <Task> task ;


    public int maxEnergy = 100;
    public int currentEnergy;
    public EnergyBar enBar;
    private bool foodConsumed;
    public int decreaseAmount; //how much should the energy deacrease
    public float decreasePerSec; //per n seconds

    private void Start()
    {
        currentEnergy = maxEnergy;
        enBar.SetMaxEnergy(maxEnergy);
        foodConsumed = false;


        StartCoroutine("DecreaseEn");

        restPoints = 0;
        maxEnergy = 100;
    }

    private void Update()
    {
        //Testing------------------

        if (Input.GetKeyDown(KeyCode.H))
        {
            AddEnergy(10);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            IncreaseMaxEnergy(50);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ReceiveRestPoints(10);
        }
        //-------------------------

    }


    //Energy Bar Code Start
    //----------------------------------------------------------------

    public void AddEnergy(int addAmount)
    {

        if (currentEnergy + addAmount >= maxEnergy)
        {
            currentEnergy = maxEnergy;
            StartCoroutine("FoodConsumed");
        }
        else
        {
            currentEnergy += addAmount;
            StartCoroutine("FoodConsumed");
        }

        if (foodConsumed)
        {
            StopCoroutine("FoodConsumed");
            StartCoroutine("FoodConsumed");
        }

        enBar.SetEnergy(currentEnergy);

    }

    public void IncreaseMaxEnergy(int maxEnIncrease)
    {
        currentEnergy += maxEnIncrease;
        maxEnergy += maxEnIncrease;
        StartCoroutine("FoodConsumed");

        if (foodConsumed)
        {
            StopCoroutine("FoodConsumed");
            StartCoroutine("FoodConsumed");
        }
        enBar.SetEnergy(currentEnergy);
    }

    //Decreases the energy value by "decrease amount" per sec ("decreasePerSec") constantly
    IEnumerator DecreaseEn()
    {
        if (currentEnergy > 0)
        {
            //decrease
            currentEnergy -= decreaseAmount;
            enBar.SetEnergy(currentEnergy);

            //wait
            yield return new WaitForSeconds(decreasePerSec);

            StartCoroutine("DecreaseEn");
        }

        if (currentEnergy <= 0)
        {
            StopCoroutine("DecreaseEn");
        }
    }

    //it stops decreasing the energy for 5 sec after consuming food
    IEnumerator FoodConsumed()
    {
        StopCoroutine("DecreaseEn");

        Debug.Log("consumed");
        foodConsumed = true;

        //wait a sec
        yield return new WaitForSeconds(5f);

        Debug.Log("continue Decreasing");
        foodConsumed = false;

        StartCoroutine("DecreaseEn");

    }

    //Energy Bar Code End
    //----------------------------------------------------------------

    //add restPoints to player
    public void ReceiveRestPoints(int amount)
    {
        restPoints += amount;
    }



}
