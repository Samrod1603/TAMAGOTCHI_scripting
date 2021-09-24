using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderNeeds : MonoBehaviour
{
    [SerializeField] NeedsSO channel;
    Slider sliderNeed;

    void Start()
    {
        sliderNeed=GetComponent<Slider>();
    }
    private void SliderChange(float hunger)
    {
        sliderNeed.value = hunger;
    }
    private void OnEnable()
    {
        channel.OnNeedChanged += SliderChange;

    }
    private void OnDisable()
    {
        channel.OnNeedChanged -= SliderChange;
    }
}
