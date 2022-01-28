using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogHappiness : MonoBehaviour
{
    public float petHappiness = 50;
    public float walkHappiness = 50;
    public float eatHappiness = 50;
    public float washHappiness = 50;

    float energyDecrease;
    float hoursDecrease;

    public float hours = 15;
    public float energy = 100;
    public float amountOfHomeworkLeft = 8;

    public float totalHappiness;

    public Text walkingText;
    public Text eatingText;
    public Text washingText;
    public Text pettingText;
    public Text totalText;

    public Text energyText;
    public Text hoursText;
    public Text homeworkText;

    bool canDoSomething = true;
    bool canDoMore = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DogHappinessControls();
        ShowValues();
        Nap();
    }

    void DogHappinessControls()
    {
        if (energyDecrease > energy)
        {
            canDoSomething = false;
        }
        else
        {
            canDoSomething = true;
        }

        if (hoursDecrease > hours)
        {
            canDoMore = false;
        }
        else 
        {
            canDoMore = true;
        }

        

       // if (canDoSomething == false) return;
       // if (canDoMore == false) return;

        if (Input.GetKeyDown(KeyCode.A))
        {
            petHappiness += 20;
            walkHappiness -= 1;
            eatHappiness -= 1;
            washHappiness -= 1;
            hoursDecrease = 0.25f;
            hours -= hoursDecrease;
            energyDecrease = 5;
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            walkHappiness += 25;
            washHappiness -= 10;
            eatHappiness -= 5;
            petHappiness -= 1;
            hoursDecrease = 1f;
            hours -= hoursDecrease;
            energyDecrease = 20;
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            eatHappiness += 20;
            walkHappiness -= 1;
            washHappiness -= 1;
            petHappiness -= 1;
            hoursDecrease = 0.5f;
            hours -= hoursDecrease;
            energyDecrease = 5;
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            washHappiness += 25;
            petHappiness -= 5;
            eatHappiness -= 1;
            walkHappiness -= 1;
            hoursDecrease = 0.5f;
            hours -= hoursDecrease;
            energyDecrease = 15;
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            amountOfHomeworkLeft -= 2;
            energyDecrease = 50;
            energy -= energyDecrease;
            hoursDecrease = 2f;
            hours -= hoursDecrease;

            washHappiness -= 10;
            petHappiness -= 10;
            eatHappiness -= 10;
            walkHappiness -= 10;
        }


        if (walkHappiness > 100)
        {
            walkHappiness = 100;
        }
        else if (walkHappiness < 0)
        {
            walkHappiness = 0;
        }

        if (washHappiness > 100)
        {
            washHappiness = 100;
        }
        else if (washHappiness < 0)
        {
            washHappiness = 0;
        }

        if (eatHappiness > 100)
        {
            eatHappiness = 100;
        }
        else if (eatHappiness < 0)
        {
            eatHappiness = 0;
        }

        if (petHappiness > 100)
        {
            petHappiness = 100;
        }
        else if (petHappiness < 0)
        {
            petHappiness = 0;
        }

        totalHappiness = petHappiness + eatHappiness + walkHappiness + walkHappiness;
    }

    void ShowValues()
    {
        walkingText.text = "Walking: " + walkHappiness;
        eatingText.text = "Eating: " + eatHappiness;
        washingText.text = "Washing: " + washHappiness;
        pettingText.text = "Petting: " + petHappiness;
        totalText.text = "TOTAL HAPPINESS: " + totalHappiness;
        hoursText.text = "Hours left: " + hours;
        energyText.text = "Energy left: " + energy;
        homeworkText.text = "Homework left: " + amountOfHomeworkLeft;
    }

    void Nap()
    {
        if (hoursDecrease > hours)
        {
            canDoMore = false;
        }
        else
        {
            canDoMore = true;
        }

        if (canDoMore == false) return;

        if (Input.GetKeyDown(KeyCode.N))
        {
            energy += 50;
            hoursDecrease = 1f;
            hours -= hoursDecrease;
            washHappiness -= 5;
            petHappiness -= 5;
            eatHappiness -= 5;
            walkHappiness -= 5;
        }

    }
}
