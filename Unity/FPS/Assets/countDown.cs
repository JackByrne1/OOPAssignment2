using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class countDown : MonoBehaviour
{

    public float timeRemaining = 15;
    public float HighScore;
    

    // Update is called once per frame
    void Update()
    {
        timeRemaining= timeRemaining - Time.deltaTime;
    }

    void OnGUI()
    {
        
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(50, 50, 200, 100), "Time Remaining: " + (int)timeRemaining);

        }
        else
        {
            GUI.color = Color.red;
            GUI.Label(new Rect(50, 50, 200, 100), "Time's Up!");
            StartCoroutine(waiter());
            if (SceneManager.GetActiveScene().buildIndex < 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
            else
            {
                SceneManager.LoadScene("Menu");

            }



        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(10);
    }
}
