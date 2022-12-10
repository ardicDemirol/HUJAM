using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{
    int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    [SerializeField] GameObject passwordScreen;

    public Text passwordText;
    [SerializeField] Text password ;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            passwordScreen.SetActive(true);
            Debug.Log("carpti");
        }
    }

    public void KeyButton(string key)
    {
        passwordText.text=passwordText.text + key;
        
    }

    public void ResetPassword()
    {
        passwordText.text = "";


    }

    public void CheckPassword()
    {
        if(passwordText==password)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            ResetPassword();
        }

    }

  
}
