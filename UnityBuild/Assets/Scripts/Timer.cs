using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time = 10;
    public Text timeText;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
  
        timeText.text = "Time : 00 " + time;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false && time > 0)
        {
            StartCoroutine(TimerTake());
        }
        else if(gameOver == false && time <=0)
        {
            Debug.Log("WIN");
        }
        
           
        
  
  
        
    }

    IEnumerator TimerTake()
    {
        gameOver = true;
        yield return new WaitForSeconds(1);
        time -= 1;
        if(time < 10)
        {
            timeText.text = "Time : 00:0" + time;
        }
        else
        {
            timeText.text = "Time : 00:" + time;
        }
        gameOver = false;
    }
}
