using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    //public Text scoreText;
    public TMP_Text scoreText;
    public int highScore;

    public GameObject player;

    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        highScore = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if ( player != null )
        {
            int score = (int)Time.timeSinceLevelLoad;
            if (score > highScore)
            {
                highScore = score;
            }
            scoreText.text = $"SCORE: {score}";
        }
        else
        {
            scoreText.text = $"YOU GOT: {highScore}!";
        }
    }
}
