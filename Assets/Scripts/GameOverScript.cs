using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

    int score = 0;
	void Start () {
		score = (int)PlayerPrefs.GetFloat ("Score");
        
	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 250, 80, 30), "GAME OVER");
		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);

		if(GUI.Button(new Rect(Screen.width /2 -30, 350, 60,30), "Retry?"))
			{
				SceneManager.LoadScene(0);
			}
        if (GUI.Button(new Rect(Screen.width /2 -30,400,60,30),"Exit"))
        {
            Application.Quit();
        }

}
}