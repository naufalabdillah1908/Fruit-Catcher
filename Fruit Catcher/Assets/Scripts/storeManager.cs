using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class storeManager : MonoBehaviour
{
    public GameObject panelStore;
    public PlayerMovement script;
    public ScoreManager script2;
    public ItemStore itemStore1, itemStore2, itemStore3, Multiplier1, Multiplier2, Multiplier3;

    public bool item1 = false;
    public bool item2 = false;
    public bool item3 = false;
    public bool multi1 = false;
    public bool multi2 = false;
    public bool multi3 = false;

    public void HideControl() 
    {
        if (Time.timeScale == 1) {
            panelStore.SetActive (true);
            Time.timeScale = 0;
        } else {
            Time.timeScale = 1;
            panelStore.SetActive (false);
        }
    }

    public void buyItem1 () {
        if (item1 == false && script2.money >= itemStore1.harga) {
            script.speed = 5;
            script2.money = script2.money - itemStore1.harga;
            item1 = true;
            print(script2.money);
            //itemStore1.buyItem();
        }
        
    }

    public void buyItem2 () {
        if (item1 == true && item2 == false && script2.money >= itemStore2.harga) {
            script.speed = 10;
            script2.money = script2.money - itemStore2.harga;
            item2 = true;
            print(script2.money);

        }
    }

    public void buyItem3 () {
        if (item2 == true && item3 == false && script2.money >= itemStore3.harga) {
            script.speed = 15;
            script2.money = script2.money - itemStore3.harga;
            item3 = true;
            print(script2.money);
        }
    }

    public void buyMultiplier1 () {
        if(script2.money >= Multiplier1.harga) {
            script2.Multiplier = 2;
            script2.money = script2.money - Multiplier1.harga;
            print("Multiplier upgraded");
            multi1 = true;
        }
    }

    public void buyMultiplier2 () {
        if(script2.money >= Multiplier1.harga && multi1 == true) {
            script2.Multiplier = 3;
            script2.money = script2.money - Multiplier1.harga;
            print("Multiplier upgraded");
            multi2 = true;
        }
    }

    public void buyMultiplier3 () {
        if(script2.money >= Multiplier1.harga && multi2 == true) {
            script2.Multiplier = 5;
            script2.money = script2.money - Multiplier1.harga;
            print("Multiplier upgraded");
            multi3 = true;
        }
    }

}
