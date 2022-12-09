using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectSliding : MonoBehaviour
{
    [SerializeField] bool unlocked;
    public Image unlockImage;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateLevelImage();
        UpdateLevelStatus();
    }

    void UpdateLevelStatus()
    {
        int previousLevelNum = int.Parse(gameObject.name) - 1;
        if (PlayerPrefs.GetInt("Sliding Lv" + previousLevelNum) > 0)
        {
            unlocked = true;
        }
    }

    void UpdateLevelImage()
    {
        if (!unlocked)
        {
            unlockImage.gameObject.SetActive(true);

        }
        else
        {
            unlockImage.gameObject.SetActive(false);

        }
    }

    public void LoadScene(string scene)
    {
        if (unlocked)
        {
            SceneManager.LoadScene(scene);

        }
    }

}
