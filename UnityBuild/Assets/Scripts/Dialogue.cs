using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    bool moveToNextDay = false;

    public GameObject continueButton;

    public PlayerEnergyUI playerEnergyUI;
    public CalenderSystem calenderSystem;
    public DogHappinessSystem dogHappinessSystem;

    void Start()
    {
        StartCoroutine(Type());
    }


    private void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        if(moveToNextDay == true)
        {
       
            SceneManager.LoadScene(0);
            SaveManager.Instance.LoadGame(dogHappinessSystem, playerEnergyUI, calenderSystem);
        }
   
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());

        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            moveToNextDay = true;
        }
    }


}
