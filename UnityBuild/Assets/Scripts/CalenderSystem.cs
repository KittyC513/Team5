using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalenderSystem : MonoBehaviour
{
    public DogHappinessSystem dogHappySystem;
    public PlayerEnergyUI playerEnergyUI;
    public Text DateText;
    public int dayCount = 1;

    public bool day2;
    public bool day3;
    public bool day4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateText.text = "Day" + dayCount;

        if(day2 == true)
        {
            Day2();
        }

        if(day3 == true)
        {
            Day3();
        }

        if (day4 == true)
        {
            Day4();
        }




    }

    public void PassADay()
    {
        dayCount += 1;

        if (dayCount == 2)
        {
            day2 = true;
            day3 = false;
            day4 = false;
        }
        else if (dayCount == 3)
        {
            day2 = false;
            day3 = true;
            day4 = false;
        }
        else if (dayCount == 4)
        {
            day2 = false;
            day3 = false;
            day4 = true;
        }

        //SaveManager.Instance.SaveGame(dogHappySystem, playerEnergyUI, this);
        //SceneManager.LoadScene(3);

        
    }


    public void Day2()
    {
        SaveManager.Instance.SaveGame(dogHappySystem, playerEnergyUI, this);
        SceneManager.LoadScene(4);
    }



    public void Day3()
    {
        SaveManager.Instance.SaveGame(dogHappySystem, playerEnergyUI, this);
        SceneManager.LoadScene(5);
    }


    public void Day4()
    {
        SaveManager.Instance.SaveGame(dogHappySystem, playerEnergyUI, this);
        SceneManager.LoadScene(6);
    }
}
