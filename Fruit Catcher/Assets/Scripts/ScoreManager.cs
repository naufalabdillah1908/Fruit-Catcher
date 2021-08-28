using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //public static ScoreManager instance;

    public Text scoreText;
    public Text LastScoreText;
    public Text moneyText;
    
    public int score;
    public int LastScore;
    public int HighScore;
    public int money;
    public int Multiplier = 1;

    
    void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        HighScore = PlayerPrefs.GetInt("HS", 0);
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
            GetComponent<AudioSource>().Play();
            score = score + (10*Multiplier);
            LastScore = score;
            money = money + (10*Multiplier);
            Destroy (target.gameObject);
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
            if (LastScore >= HighScore)
            {
                HighScore = LastScore;
                PlayerPrefs.SetInt("HS", HighScore);
            }
        }
        if (target.tag == "strawberry") {
            GetComponent<AudioSource>().Play();
            Destroy (target.gameObject);
            score = score + (2*Multiplier);
            LastScore = score;
            money = money + (2*Multiplier);
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
            if (LastScore >= HighScore)
            {
                HighScore = LastScore;
                PlayerPrefs.SetInt("HS", HighScore);
            }
        }
        if (target.tag == "apple") {
            GetComponent<AudioSource>().Play();
            Destroy (target.gameObject);
            score = score + (15*Multiplier);
            LastScore = score;
            money = money + (15*Multiplier);
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
            if (LastScore >= HighScore)
            {
                HighScore = LastScore;
                PlayerPrefs.SetInt("HS", HighScore);
            }
        }

    }


    void buyItem(){
        moneyText.text = money.ToString();
    }
}

