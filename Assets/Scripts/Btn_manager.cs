﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_manager : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
    }
    
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
