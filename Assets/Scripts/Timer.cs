using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float duplicateInverval;
    public GameObject enemyObj;


    private float timeRecord;
    private float timeInterval;
    void Update()
    {
        timeRecord += Time.deltaTime;
        timeInterval += Time.deltaTime;

        float seconds = timeRecord % 60;

        timerText.text = string.Format("Timer {0:00}", 60-seconds);
        // 60 seconds timer

        if(timeInterval > duplicateInverval)
        {
            timeInterval = 0;
            DuplicateObj();
            // every duplicateInterval(seconds), enemy will generated.
        }
        Debug.Log(timeRecord);
        if (timeRecord > 60)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // if player survives more than 60 seconds, will proceed to next level
        }
        
    }

    void DuplicateObj()
    {
        GameObject clone = GameObject.Instantiate(enemyObj);
        clone.transform.position = new Vector3(0, 0, 0); //position where enemy generated
    }
}
