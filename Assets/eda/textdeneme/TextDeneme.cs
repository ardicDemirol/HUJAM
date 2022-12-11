using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class TextDeneme : MonoBehaviour
{
    public float delay;

   


    [Multiline]
    public string startText;

    TextMeshProUGUI thisText;

    private void Start()
    {
       
        thisText = GetComponent<TextMeshProUGUI>();

        StartCoroutine(TypeWrite());

    }

    IEnumerator TypeWrite()
    {
        foreach(char i in startText)
        {
            thisText.text += i.ToString();
          

            if(i.ToString()== ".")
            {
                yield return new WaitForSeconds(1);
            }
            else
            {
                yield return new WaitForSeconds(delay);
            }
        }
    }

}
