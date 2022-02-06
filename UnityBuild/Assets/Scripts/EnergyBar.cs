using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    // Start is called before the first frame update
    public void SetMaxEnergy(int energyValue)
    {
        slider.maxValue = energyValue;
        slider.value = energyValue;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetEnergy(int energyValue)
    {
        slider.value = energyValue;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }



}
