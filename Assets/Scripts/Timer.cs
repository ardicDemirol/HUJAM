using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] private Image timerImg;
    [SerializeField] private Text timerText;


    [SerializeField] private GameObject deathScreen;

    private float currentTime;
    [SerializeField] private float duration;


    void Start()
    {
        currentTime = duration;
        timerText.text = currentTime.ToString();
        StartCoroutine(Updatetime());

    }

    private IEnumerator Updatetime()
    {
        while (currentTime >= 0)
        {
            timerImg.fillAmount = Mathf.InverseLerp(0,duration,currentTime);
            timerText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
            if(currentTime <= 0)
            {
                deathScreen.SetActive(true);
                gameObject.SetActive(false);
                
            }

        }
        yield return null;
    }


}
