using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    public GameObject Achievementstore;
    public GameObject panelPause;
    public GameObject Ach1, Ach2, Ach3;
    public ScoreManager scriptMoney;
    int suicidecount;

    public void HideAch()
    {
        Achievementstore.SetActive (true);
        panelPause.SetActive(false);
        Time.timeScale = 0;
        
    }

    public void GoBack()
    {
        Achievementstore.SetActive(false);
        panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    void Start()
    {
        suicidecount = PlayerPrefs.GetInt("SC", 0);
    }

    void Update()
    {
        if (scriptMoney.money >= 1000) 
        {
            Ach1.SetActive(true);
        }

        if (scriptMoney.HighScore >= 2000)
        {
            Ach2.SetActive(true);
        }

        if ((scriptMoney.score == 0 && GameController.health == 0))
        {
            suicidecount += 1;
            Ach3.SetActive(true);
            PlayerPrefs.SetInt("SC", suicidecount);
        } else if (suicidecount >=1)
        {
            Ach3.SetActive(true);
        }
    }


}
