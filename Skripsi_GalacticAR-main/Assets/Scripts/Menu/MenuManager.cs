using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public string url;

    public void exit()
    {
        Application.Quit();
    }
    
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
