using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalenderSystem : MonoBehaviour
{
    public Text DateText;
    int dayCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateText.text = "Day" + dayCount;
    }

    public void PassADay()
    {
        SceneManager.LoadScene(3);
        dayCount += 1;

    }
}
