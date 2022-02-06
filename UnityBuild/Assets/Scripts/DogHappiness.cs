using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        Debug.Log("energy decrease is " + energyDecrease);
        Debug.Log("hours decrease is " + hoursDecrease);

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

        

       
       

        if (Input.GetKeyDown(KeyCode.A))
        {
            hoursDecrease = 0.25f;
            energyDecrease = 5;



            if (energyDecrease > energy) return;
            if (hoursDecrease > hours) return;

            petHappiness += 20;
            walkHappiness -= 1;
            eatHappiness -= 1;
            washHappiness -= 1;

            hours -= hoursDecrease;
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {

   
            energyDecrease = 20;
            hoursDecrease = 1f;



            if (energyDecrease > energy) return;
            if (hoursDecrease > hours) return;
     

            walkHappiness += 25;
            washHappiness -= 10;
            eatHappiness -= 5;
            petHappiness -= 1;
            
            hours -= hoursDecrease;
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
         
                 
            hoursDecrease = 0.25f;
            energyDecrease = 5;

            if (energyDecrease > energy) return;
            if (hoursDecrease > hours) return;

            eatHappiness += 20;
            walkHappiness -= 1;
            washHappiness -= 1;
            petHappiness -= 1;
            
            hours -= hoursDecrease;
            
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            hoursDecrease = 0.5f;
            energyDecrease = 15;

            if (energyDecrease > energy) return;
            if (hoursDecrease > hours) return;

            washHappiness += 25;
            petHappiness -= 5;
            eatHappiness -= 1;
            walkHappiness -= 1;
            
            hours -= hoursDecrease;
            energy -= energyDecrease;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            energyDecrease = 50;
            hoursDecrease = 2f;

            if (energyDecrease > energy) return;
            if (hoursDecrease > hours) return;

            amountOfHomeworkLeft -= 2;
            
            energy -= energyDecrease;
            
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

        

        if (Input.GetKeyDown(KeyCode.N))
        {
            hoursDecrease = 1f;

            if (hoursDecrease > hours) return;

            energy += 50;
            
            hours -= hoursDecrease;
            washHappiness -= 5;
            petHappiness -= 5;
            eatHappiness -= 5;
            walkHappiness -= 5;
        }

    }


}
