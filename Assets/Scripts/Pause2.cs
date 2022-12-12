using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause2 : MonoBehaviour
{

    public bool isPaused = false;

    public GameObject pauseMenu;

    Shoot shoot;


    private void Start()
    {
        shoot = GetComponent<Shoot>();
        isPaused = false;
        Time.timeScale = 1f;
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
        shoot.canShoot = true;
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("resume");

    }


    public void PauseGame()
    {
        shoot.canShoot = false;
        isPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("pause");

    }




}
