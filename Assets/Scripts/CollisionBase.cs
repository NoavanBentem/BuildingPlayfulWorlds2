using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBase: MonoBehaviour {
    int baseCount;
    bool touchBase = false;

    public GameObject Player;


	void Start () 
    {
        baseCount = 0;
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
            touchBase = true;
            baseCount = baseCount + 1;
            print("TOUCHING SPAWNER!");
        }
        else
        {
            touchBase = false;
        }    

    }
}
