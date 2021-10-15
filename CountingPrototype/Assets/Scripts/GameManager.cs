using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text scoreCounter;
    public GameObject ball;

    bool gameOver = false;
    public GameObject spawnPont;
    public int _score { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        _score = 0;
        scoreCounter.text = "Score: " + _score;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Ball") == null && !gameOver)
        {
            Debug.Log("Need Ball");
            Instantiate(ball, spawnPont.transform.position, ball.transform.rotation);
        }
    }

    public void AddScore(int score)
    {
        _score += score;
        scoreCounter.text = "Score: " + _score;
    }
    public void IsGameOver()
    {
        gameOver = true;
        Debug.Log("Game Over");
        scoreCounter.text += " GameOver!";
    }
}
