using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungryBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    // Start is called before the first frame update
  
    public void SetMaxHungry(int hungry)
    {
        slider.maxValue = hungry;
        slider.value = hungry;

        fill.color = gradient.Evaluate(1f);
    }
    

    public void SetHungry(int hungry)
    {
        slider.value = hungry;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    

}
