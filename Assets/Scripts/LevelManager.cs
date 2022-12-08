using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< Updated upstream:Assets/Scripts/Menu.cs
public class Menu : MonoBehaviour
=======
public class LevelManager : MonoBehaviour
>>>>>>> Stashed changes:Assets/Scripts/LevelManager.cs
{

    int nextSceneIndex;
    int currentSceneIndex;

    private void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;   

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
        
       

        

        

