using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour 

{
    public Renderer rend;
    AudioSource collectSource;
    HUD hud;
    


    private void Start()
    {
        rend = GetComponent<Renderer>();
        collectSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
	{
        
        if (other.tag == "Player") {
            collectSource.Play();
            hud = GameObject.Find ("Main Camera").GetComponent<HUD> ();
            hud.IncreaseScore(10);
            rend.enabled = false;
            Destroy (this.gameObject, collectSource.clip.length);
        }
	}


}
