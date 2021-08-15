using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text LastScoreText;
    public Text moneyText;
    
    int score;
    int LastScore;
    int money;

    
    void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        score = 0;
        //scoreText = GetComponent<Text> ();
        scoreText.text = score.ToString();
        LastScoreText.text = LastScore.ToString() + " POINTS";
        moneyText.text = money.ToString();
    }

    

    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "bomb") {
            GameController.health = 0;
        }
        if (target.tag == "watermelon") {
            score = score + 10;
            LastScore = score;
            money = money + 10;
            Destroy (target.gameObject);
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
        }
        if (target.tag == "strawberry") {
            Destroy (target.gameObject);
            score = score + 2;
            LastScore = score;
            money = money + 2;
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
        }
        if (target.tag == "apple") {
            Destroy (target.gameObject);
            score = score + 5;
            LastScore = score;
            money = money + 5;
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
        }

    }
}

