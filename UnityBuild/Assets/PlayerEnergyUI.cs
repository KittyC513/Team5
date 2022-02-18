using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyUI : MonoBehaviour
{
    public int energy;
    public int homeworkLeft;
    public int numOfEnergy;
    public int numOfHomeworkLeft;

    public Image[] energyIcons;
    public Image[] homeworkIcons;
    public Sprite fullEnergyIcons;
    public Sprite fullHomeIcons;
    public Sprite emptyEnergyIcons;
    public Sprite emptyHomeworkIcons;

    public bool spendingEnergy;
    public bool isDoingHomework;
    public bool regainingEnergy;
    public bool isPassTheDay;

    public GameObject FeedButton;
    public GameObject PetButton;
    public GameObject WalkButton;
    public GameObject WashButton;
    public GameObject StudyButton;
 



    private void Start()
    {
        //energy = energyIcons.Length;

    }
    void Update()
    {
        if(energy > numOfEnergy)
        {
            energy = numOfEnergy;

        }


        for( int i = 0; i < energyIcons.Length; i++)
        {
            if(i < energy)
            {
                energyIcons[i].sprite = fullEnergyIcons;
            }
            else
            {
                energyIcons[i].sprite = emptyEnergyIcons;
            }

            if(i < numOfEnergy)
            {
                energyIcons[i].enabled = true;
            }
            else
            {
                energyIcons[i].enabled = false;
            }
        }

        if(homeworkLeft > numOfHomeworkLeft)
        {
            homeworkLeft = numOfHomeworkLeft;
        }

        for( int i = 0; i < homeworkIcons.Length; i++)
        {
            if(i < homeworkLeft)
            {
                homeworkIcons[i].sprite = fullHomeIcons;
            }
            else
            {
                homeworkIcons[i].sprite = emptyHomeworkIcons;
            }
            if(i < numOfHomeworkLeft)
            {
                homeworkIcons[i].enabled = true;
            }
            else
            {
                homeworkIcons[i].enabled = false;
            }
        }





    }

    public void EnergySpending(int playerEnergyValue)
    {
        energy -= playerEnergyValue;
        Debug.Log(energy);

        if(energy<= 0)
        {
            FeedButton.SetActive(false);
            PetButton.SetActive(false);
            WalkButton.SetActive(false);
            WashButton.SetActive(false);
            StudyButton.SetActive(false);

        }

    }


    public void EnergyRegaining(int playerEnergyValue)
    {
        energy += playerEnergyValue;
        
        if(energy > 0)
        {
            FeedButton.SetActive(true);
            PetButton.SetActive(true);
            WalkButton.SetActive(true);
            WashButton.SetActive(true);
            StudyButton.SetActive(true);
        }


        
    }

    public void DoingHomework(int homeworkValue)
    {
        homeworkLeft -= homeworkValue;
    }

  


}
