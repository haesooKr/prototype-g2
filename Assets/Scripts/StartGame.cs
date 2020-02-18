using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Scene_0");
        // start game with level 1 (Scene_0 is level 1)
    }
}
