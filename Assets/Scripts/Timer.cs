using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timeRecord;
    void Update()
    {
        timeRecord += Time.deltaTime;

        float minutes = timeRecord / 60;
        float seconds = timeRecord % 60;

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        
    }
}
