using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public  bool isPaused = false;
    

    public GameObject pauseMenu;
    [SerializeField] GameObject timeHud;


    private void Start()
    {
        isPaused = false;
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Level1Info", 0);
        if (PlayerPrefs.GetInt("Level1Info") == 0)
        {
            PlayerPrefs.SetInt("Level1Info", 1);
        }
        else
        {

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }


    public void ResumeGame()
    {
        
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        
        
    }


    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }


}
