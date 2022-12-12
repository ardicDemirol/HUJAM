using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Password : MonoBehaviour
{

    [SerializeField] GameObject passwordScreen;

    public TextMeshProUGUI passwordText;
    string password = "2514";

    public bool openPanel = false;
    private int nextSceneIndex;
    Pause pause;


    private void Start()
    {

        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        pause = GetComponent<Pause>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            openPanel = true;
            passwordScreen.SetActive(true);
            Debug.Log("carpti");
        }

    }

    public void KeyButton(string key)
    {
        passwordText.text += key;
        Debug.Log(passwordText.text);
    }

    public void ResetPassword()
    {
        passwordText.text = "";
    }

    public void CheckPassword()
    {
        string newPassword = passwordText.text.ToString();

        if (newPassword == password)
        {
            SceneManager.LoadScene(nextSceneIndex);
            
        }
        else
        {
            ResetPassword();
            
        }
    }
    public void ClosePanel()
    {
        passwordScreen.SetActive(false);
    }

}
