﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        int buildIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(buildIndex);
        if (buildIndex >= 3)
        {
            SceneManager.LoadScene(2);
        }
        else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
     
    }
    public void QuitGame()
    {
        //this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Debug.Log("Quit!");
        Application.Quit();
    }
}
