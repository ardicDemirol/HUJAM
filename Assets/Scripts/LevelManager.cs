using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    int nextSceneIndex;
    int currentSceneIndex;

    Pause pause;

    private void Start()
    {
        pause = GetComponent<Pause>();
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Play()

    {
        SceneManager.LoadScene(1);
    }

    public void Quit()

    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
    public void RestartLevel()
    {
        pause.ResumeGame();
        pause.pauseMenu.SetActive(false);
        SceneManager.LoadScene(currentSceneIndex);
        

    }









}
