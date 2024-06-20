using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    //public Text scoreText;
    public TMP_Text scoreText;

    public GameObject player;

    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if ( player != null )
        {
            scoreText.text = $"SCORE: {(int)Time.timeSinceLevelLoad}";
        }
    }
}
