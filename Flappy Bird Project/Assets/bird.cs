using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    public float velocity = 1f;
    private Rigidbody2D rb;
    public gameManager GameManager;
    public int highScore;
    public Text highScoreTextBox;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreTextBox.text = "Highscore: " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //jump
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();

        if (GetComponent<pointGain>().points > highScore) { 
        highScore = GetComponent<pointGain>().points;
        highScoreTextBox.text = "Highscore: " + highScore.ToString();
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
