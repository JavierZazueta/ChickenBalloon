﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    void PlayGame()
    {
        Debug.Log("3");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
