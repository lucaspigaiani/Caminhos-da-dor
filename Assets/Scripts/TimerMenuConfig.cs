using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMenuConfig : MonoBehaviour
{
    [SerializeField] private float matchTime = 5;
    [SerializeField] private float timeIncrease = 3;
    [SerializeField] private float timeDecrease = 1;

    [SerializeField] private Color infinityTimeColor;
    [SerializeField] private Color baseTimeColor;

    [SerializeField] private GameObject infinityTimeActive;
    [SerializeField] private GameObject infinityTimeTransparent;
    
    [SerializeField] private GameObject baseTimeActive;
    [SerializeField] private GameObject baseTimeTransparent;

    //Variaveis tempo de partida
    [SerializeField] private Color matchTimeColor;
    [SerializeField] private float baseMatchTime;


    [SerializeField] private Slider matchTimeSlider;
    [SerializeField] private Image matchTimeSliderBackground;
    [SerializeField] private Image matchTimeSliderFill;
    [SerializeField] private Image matchTimeSliderHandle;
    [SerializeField] private Text matchTimeInputText;

    //Variaveis acréscimo de tempo
    [SerializeField] private Color timeIncreaseColor;
    [SerializeField] private float baseTimeIncrease;

    [SerializeField] private Slider timeIncreaseSlider;
    [SerializeField] private Image timeIncreaseSliderBackground;
    [SerializeField] private Image timeIncreaseSliderFill;
    [SerializeField] private Image timeIncreaseSliderHandle;
    [SerializeField] private Text timeIncreaseInputText; 
    
    //Variaveis decréscimo de tempo
    [SerializeField] private Color timeDecreaseColor;
    [SerializeField] private float baseTimeDecrease;

    [SerializeField] private Slider timeDecreaseSlider;
    [SerializeField] private Image timeDecreaseSliderBackground;
    [SerializeField] private Image timeDecreaseSliderFill;
    [SerializeField] private Image timeDecreaseSliderHandle;
    [SerializeField] private Text timeDecreaseInputText;

    private void Start()
    {
        BaseTime();
    }


    public void InfinityTime() 
    {
        infinityTimeActive.SetActive(true);
        infinityTimeTransparent.SetActive(false);

        baseTimeActive.SetActive(false);
        baseTimeTransparent.SetActive(true);

        SetMatchTime(0, infinityTimeColor, false);
        SetIncreaseTime(0, infinityTimeColor, false);
        SetDecreaseTime(0, infinityTimeColor, false);
        SetPlayerPrefs();
    }

    public void BaseTime()
    {
        infinityTimeActive.SetActive(false);
        infinityTimeTransparent.SetActive(true);

        baseTimeActive.SetActive(true);
        baseTimeTransparent.SetActive(false);

        SetMatchTime(0, baseTimeColor, true);
        SetIncreaseTime(0, baseTimeColor, true);
        SetDecreaseTime(0, baseTimeColor, true);
        SetPlayerPrefs();

    }

    private void SetMatchTime(float time, Color color, bool IsBaseTime)
    {
        if (IsBaseTime == true) time = baseMatchTime;

        matchTimeSlider.value = time;
        matchTimeSliderBackground.color = color;
        matchTimeSliderFill.color = color;
        matchTimeSliderHandle.color = color;

        matchTimeInputText.color = color;
        matchTimeInputText.text = time.ToString() + ":00";

        matchTime = time;
        SetPlayerPrefs();
    }

    private void SetIncreaseTime(float time, Color color, bool IsBaseTime)
    {
        if (IsBaseTime == true) time = baseTimeIncrease;

        timeIncreaseSlider.value = time;
        timeIncreaseSliderBackground.color = color;
        timeIncreaseSliderFill.color = color;
        timeIncreaseSliderHandle.color = color;
        timeIncreaseInputText.color = color;
        timeIncreaseInputText.text = time.ToString() + ":00";
        timeIncrease = time;
        SetPlayerPrefs();
    }

    private void SetDecreaseTime(float time, Color color, bool IsBaseTime)
    {
        if (IsBaseTime == true) time = baseTimeDecrease;

        timeDecreaseSlider.value = time;
        timeDecreaseSliderBackground.color = color;
        timeDecreaseSliderFill.color = color;
        timeDecreaseSliderHandle.color = color;
        timeDecreaseInputText.color = color;
        timeDecreaseInputText.text = time.ToString() + ":00";
        timeDecrease = time;
        SetPlayerPrefs();
    }

    public void MatchTime(float time) 
    {
        DeactivateButtons();
        SetMatchTime(time, baseTimeColor, false);
        SetPlayerPrefs();
    }

    public void IncreaseTime(float time)
    {
        DeactivateButtons();
        SetIncreaseTime(time, timeIncreaseColor, false);
        SetPlayerPrefs();
    }

    public void DecreaseTime(float time)
    {
        DeactivateButtons();
        SetDecreaseTime(time, timeDecreaseColor, false);
        SetPlayerPrefs();
    }
    private void DeactivateButtons() 
    {
        infinityTimeActive.SetActive(false);
        infinityTimeTransparent.SetActive(true);

        baseTimeActive.SetActive(false);
        baseTimeTransparent.SetActive(true);
    }

    private void SetPlayerPrefs() 
    {
        PlayerPrefs.SetFloat("matchTime", matchTime);
        PlayerPrefs.SetFloat("timeIncrease", timeIncrease);
        PlayerPrefs.SetFloat("timeDecrease", timeDecrease);
    }

}
