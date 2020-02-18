using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Text levelText;
    // Update is called once per frame
    void Update()
    {
        levelText.text = string.Format("Level {0}", SceneManager.GetActiveScene().buildIndex);
    }
}
