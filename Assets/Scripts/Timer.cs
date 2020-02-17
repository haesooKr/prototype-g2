using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public GameObject enemyObj;
    private float timeRecord;
    private float timeInterval;
    void Update()
    {
        timeRecord += Time.deltaTime;
        timeInterval += Time.deltaTime;

        float minutes = timeRecord / 60;
        float seconds = timeRecord % 60;

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

        if(timeInterval > 2)
        {
            timeInterval = 0;
            DuplicateObj();
        }
        
    }

    void DuplicateObj()
    {
        GameObject clone = GameObject.Instantiate(enemyObj);
        clone.transform.position = new Vector3(0, 0, 0);
    }
}
