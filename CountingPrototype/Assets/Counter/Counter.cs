using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    GameManager gameManager;

    private int lives = 3;

    private void Start()
    {
        lives = 3;
        gameManager = GameObject.FindObjectOfType<GameManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        lives -= 1;
        counterText.text = "Lives : " + lives;
        if (lives <=0)
        {
           gameManager.IsGameOver();
        }
    }
}
