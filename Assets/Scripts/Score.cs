using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    private float gameTimer;
    private int seconds = 0;


    private void Update()
    {
        scoreText.text = (player.position.z + player.position.x).ToString("0");
       

    }


}
