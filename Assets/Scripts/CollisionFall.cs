using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFall: MonoBehaviour {

    public GameObject Player;


	void Start () 
    {
        Player = GameObject.FindWithTag("Player");
	}

    private void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
    // Checks for collision between itself and the player    
        if (other.gameObject.tag == "Player")
        {
            print("Fall Activated!");
        }

    }
}
