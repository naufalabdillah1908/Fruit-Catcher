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
    
    int score;
    int LastScore;
    public int money;
    public int Multiplier = 1;

    
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
            score = score + (10*Multiplier);
            LastScore = score;
            money = money + (10*Multiplier);
            Destroy (target.gameObject);
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
        }
        if (target.tag == "strawberry") {
            Destroy (target.gameObject);
            score = score + (2*Multiplier);
            LastScore = score;
            money = money + (2*Multiplier);
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
        }
        if (target.tag == "apple") {
            Destroy (target.gameObject);
            score = score + (15*Multiplier);
            LastScore = score;
            money = money + (15*Multiplier);
            scoreText.text = score.ToString();
            LastScoreText.text = LastScore.ToString() + " POINTS";
            moneyText.text = money.ToString();
            print(score);
            PlayerPrefs.SetInt("money", money);
        }

    }


    void buyItem(){
        moneyText.text = money.ToString();
    }
}

