using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


    int nextSceneIndex;
    int currentSceneIndex;

    private void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

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
        SceneManager.LoadScene(currentSceneIndex);
    }


}
