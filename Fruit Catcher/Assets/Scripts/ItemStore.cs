using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStore : MonoBehaviour
{
    public int harga;
    //public Sprite Imgterjual;
    public Text hargaText;


    void Start() {
        hargaText.text = harga.ToString();
    }

    //public void buyItem() {
    //    this.gameObject.GetComponent<SpriteRenderer>().sprite = Imgterjual;
    //}
    
    

    
}
