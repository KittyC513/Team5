using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogHappinessSystem : MonoBehaviour
{
    public int maxHungry = 100;
    public int currentHungry;
    //bool isFeeding = false;
    public HungryBar hungryBar;

    public int maxFun = 100;
    public int currentFun;
    public FunBar funBar;

    public int maxEnergy = 100;
    public int currentEnergy;
    public EnergyBar energyBar;

    public int maxHygiene = 100;
    public int currentHygiene;
    public HygieneBar hygieneBar;





    // Start is called before the first frame update
    void Start()
    {
        currentHungry = maxHungry;
        hungryBar.SetMaxHungry(maxHungry);

        currentFun = maxFun;
        funBar.SetMaxFun(maxFun);

        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);

        currentHygiene = maxHygiene;
        hygieneBar.SetMaxHygiene(maxHygiene);





      

    }

    // Update is called once per frame
    void Update()
    {







    }
    
       


    public void Feed(int feedValue)
    {

        if (currentEnergy >= maxHungry)
        {
            currentEnergy = maxEnergy;
            hungryBar.SetHungry(currentHungry);
        }
        else
        {
            currentHungry += 20;
            hungryBar.SetHungry(currentHungry);
        }

    }

    public void DecreaseHungryValue(int hungeyValue)
    {
        if (currentEnergy <= 0)
        {
            currentEnergy = 0;
            hungryBar.SetHungry(currentHungry);
        }
        else
        {
            currentHungry -= 5;
            hungryBar.SetHungry(currentHungry);
        }

    }

    public void Entertain(int funValue) 
    {
        if (currentFun >= maxFun)
        {
            currentFun = maxFun;
            funBar.SetFun(currentFun);
        }
        else
        {
            currentFun += 15;
            funBar.SetFun(currentFun);
        }

    }

    public void DecreaseFunValue(int funValue)
    {
        if (currentFun <= 0)
        {
            currentFun = 0;
            funBar.SetFun(currentFun);
        }
        else
        {
            currentFun -= 10;
            funBar.SetFun(currentFun);
        }




    }


    public void Walk(int energyValue)
    {

        if (currentHungry >= maxHungry)
        {
            currentHungry = maxHungry;
            energyBar.SetEnergy(currentEnergy);
        }
        else
        {
            currentEnergy += energyValue;
            energyBar.SetEnergy(currentEnergy);
        }

    } 

    public void DecreaseEnergyValue(int energyValue)
    {
        if (currentEnergy <= 0)
        {
            currentEnergy = 0;
            energyBar.SetEnergy(currentEnergy);
        }
        else
        {
            currentEnergy -= energyValue;
            energyBar.SetEnergy(currentEnergy);
        }

    }

    public void Wash(int hygieneValue)
    {

        if (currentHygiene >= maxHygiene)
        {
            currentHygiene = maxHygiene;
            hygieneBar.SetHygiene(currentHygiene);
        }
        else
        {
            currentHygiene += hygieneValue;
            hygieneBar.SetHygiene(currentHygiene);
        }

    }

    public void DecreaseHygieneValue(int hyGieneValue)
    {
        if (currentHygiene <= 0)
        {
            currentEnergy = 0;
            hygieneBar.SetHygiene(currentHygiene);
        }
        else
        {
            currentHygiene -= hyGieneValue;
            hygieneBar.SetHygiene(currentHygiene);
        }

    }

}
