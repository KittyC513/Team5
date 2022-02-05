using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogHappinessSystem : MonoBehaviour
{
    public int maxHungry = 100;
    public int currentHungry;
    //bool isFeeding = false;
    public HungryBar hungryBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHungry = maxHungry;
        hungryBar.SetMaxHungry(maxHungry);
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
}
