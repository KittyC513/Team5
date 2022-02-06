using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HygieneBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    // Start is called before the first frame update
    public void SetMaxHygiene(int hygiene)
    {
        slider.maxValue = hygiene;
        slider.value = hygiene;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetHygiene(int hygiene)
    {
        slider.value = hygiene;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }



}
