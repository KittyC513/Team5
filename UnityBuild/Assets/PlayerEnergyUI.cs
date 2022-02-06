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


}
