using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    int lives = 3;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddLives(int value)
    {
        lives += value;
        Debug.Log("Lives = " + lives);

        if (lives <= 0)
        {
            Debug.Log("GAME OVER!!");
            lives = 0;
        }
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}
