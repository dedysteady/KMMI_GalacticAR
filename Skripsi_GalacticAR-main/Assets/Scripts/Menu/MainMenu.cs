using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;

    public void GoToGame()
    {
        SceneManager.LoadScene(4);
    }
    
    public void GoToRegister()
    {
        SceneManager.LoadScene(3);
    }
    
    public void GoToLogin()
    {
        SceneManager.LoadScene(2);
    }
}
