using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Functionality : MonoBehaviour
{
    public static float millsCount;
    public static float secondsCount;
    public static int minuteCount;
    public static int hourCount;

    public Text timerText;
    // Use this for initialization
    void Start()
    {
        timerText = GameObject.Find("TimerTest").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
    }

    public void UpdateTimerUI()
    {
        //set timer UI
        millsCount = Time.deltaTime * 1000;

        secondsCount += Time.deltaTime;
        timerText.text = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s:" + (int)millsCount + "mil";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }
}
