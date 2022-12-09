using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    public Text playerDisplay;

    // Start is called before the first frame update
    private void Awake()
    {
        if (DBManager.username == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        playerDisplay.text = "Hai, " + DBManager.username + "\nMari Belajar Bersama";
    }

    public void GotoMainMenu()
    {
        DBManager.LogOut();
        SceneManager.LoadScene(1);
    }
}
