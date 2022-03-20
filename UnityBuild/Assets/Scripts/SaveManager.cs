using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    public int _currentHungry = 100;
    public int _currentEnergy = 100;
    public int _currentHygiene = 100;
    public int _currentFun = 100;
    public int _playerEnergy = 7;
    public int _currentHomeworkLeft = 2;
    public int _dayCount = 1;
  

    
    public static SaveManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; //set to the instance this code is currently running in 
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); //prevents any further instances from being created in new scenes 
            return;
        }
    }

    public void SaveGame(DogHappinessSystem dogHappySystem, PlayerEnergyUI playerEnergyUI, CalenderSystem calenderSystem)
    {
        _currentHungry = dogHappySystem.currentHungry;
        _currentEnergy = dogHappySystem.currentEnergy;
        _currentFun = dogHappySystem.currentFun;
        _currentHygiene = dogHappySystem.currentHygiene;

        _playerEnergy = playerEnergyUI.energy;
        _currentHomeworkLeft = playerEnergyUI.homeworkLeft;

        _dayCount = calenderSystem.dayCount;
    }

    public void LoadGame(DogHappinessSystem dogHappySystem, PlayerEnergyUI playerEnergyUI, CalenderSystem calenderSystem)
    {
        dogHappySystem.currentHungry = _currentHungry;
        dogHappySystem.hungryBar.SetHungry(_currentHungry);

        dogHappySystem.currentEnergy = _currentEnergy;
        dogHappySystem.energyBar.SetEnergy(_currentEnergy);

        dogHappySystem.currentFun = _currentFun;
        dogHappySystem.funBar.SetFun(_currentFun);

        dogHappySystem.currentHygiene = _currentHygiene;
        dogHappySystem.hygieneBar.SetHygiene(_currentHygiene);
       
        playerEnergyUI.energy = _playerEnergy;
        playerEnergyUI.homeworkLeft = _currentHomeworkLeft;

        calenderSystem.dayCount = _dayCount;
    }

    public void LoadEnding()
    {
        float totalHappiness = _currentFun + _currentHungry + _currentHygiene;

        Debug.Log(_dayCount);
        Debug.Log(totalHappiness);

        if (_dayCount >= 4)
        {
            if (_currentHomeworkLeft > 5 && totalHappiness > 200)
            {
                SceneManager.LoadScene("DogStaysPlayerHasNoJob");
            }
        }
    }

}
