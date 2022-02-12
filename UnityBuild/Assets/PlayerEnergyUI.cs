using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyUI : MonoBehaviour
{
    public int energy;
    public int numOfEnergy;

    public Image[] energyIcons;
    public Sprite fullEnergyIcons;
    public Sprite emptyEnergyIcons;

    public bool spendingEnergy;
    public bool regainingEnergy;

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


        for( int i =0; i < energyIcons.Length; i++)
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


}
