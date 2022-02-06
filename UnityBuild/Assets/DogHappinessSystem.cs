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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Feed(10);
        }
    }

    void Feed(int feedValue)
    {
        currentHungry -= 10;
        hungryBar.SetHungry(currentHungry);
    }

    void Entertain(int funValue) 
    {
        currentFun -= 10;
        funBar.SetFun(currentFun);
    }

    void Walk(int energyValue)
    {
        currentEnergy -= 10;
        energyBar.SetEnergy(currentEnergy);
    } 

    void Wash(int washValue)
    {
        currentHygiene -= 10;
        hygieneBar.SetHygiene(currentHygiene);
    }
}
