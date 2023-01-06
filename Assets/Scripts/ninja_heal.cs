using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ninja_heal : MonoBehaviour
{
    TextMeshProUGUI time;
  
    public static Image heart;

    public GameObject lose, win;
    int x;
    public static float heal_count=3, heal_new_count = 3;
    public float timeRemaining = 59;
    public bool timerIsRunning = false;

    
    void Start()
    {
        Time.timeScale = 1;
        time = GameObject.Find("Canvas/time").GetComponent<TextMeshProUGUI>();
        heart = GameObject.Find("Canvas/black_heart/red_heart").GetComponent<Image>();
        timerIsRunning = true;
        time.text = timeRemaining.ToString();
        heal_new_count = 3;
        heal_count = 3;
    }

 public void replay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        
    }
    public void exit()
    {
        Application.Quit();
    }
    void Update()
    {
        
            if (timerIsRunning)

        {

            if (timeRemaining > 0)

            {

                timeRemaining -= Time.deltaTime;
                x = Mathf.RoundToInt(timeRemaining);
                time.text=x.ToString();

                if(heal_new_count == 0)
                {
                   
                    lose.SetActive(true);
                    Time.timeScale = 0;


                }
                

            }

            else

            {
                

                if(heal_new_count <= 3)
                {
                   
                   win.SetActive(true);
                    Time.timeScale = 0;

                }
                timeRemaining = 0;

                timerIsRunning = false;

            }

        }



    }
}
