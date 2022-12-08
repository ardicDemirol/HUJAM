using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    int nextSceneIndex;

    private void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

    }
    public void PlayButton()

    {
       
        SceneManager.LoadScene(1);
    }

    public void QuitButton()

    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextSceneIndex);

    }

    
    
}
        
       

        

        

