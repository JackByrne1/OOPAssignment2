using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public float timeRemaining;

	public void PlayGame ()
	{
        timeRemaining = 15;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void PlayGame2 ()
	{
        timeRemaining = 10;

        SceneManager.LoadScene ("prac2");
	}

	public void PlayGame3 ()
	{
        timeRemaining = 5;

        SceneManager.LoadScene ("prac3");
	}
}

