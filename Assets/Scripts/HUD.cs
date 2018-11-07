using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

	float playerScore = 0;

	
	// Update is called once per frame
	void Update ()

	{
		playerScore += Time.deltaTime;	
	}

	void OnDisable()
	{
		PlayerPrefs.SetFloat ("Score", playerScore*10);
	}

	public void IncreaseScore (int amount)
	{
		playerScore += amount;
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 30), "Score: " + (int)(playerScore * 10));
	}
}
