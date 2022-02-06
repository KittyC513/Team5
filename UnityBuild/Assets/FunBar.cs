using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    // Start is called before the first frame update
    public void SetMaxFun(int fun)
    {
        slider.maxValue = fun;
        slider.value = fun;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetFun(int fun)
    {
        slider.value = fun;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }



}
