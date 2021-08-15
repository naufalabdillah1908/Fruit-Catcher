using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colector : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "bomb" || target.tag == "strawberry" || target.tag == "apple" || target.tag == "watermelon") {
            Destroy (target.gameObject);
        }

        if (target.tag == "strawberry" || target.tag == "apple" || target.tag == "watermelon")
        {
            GameController.health -= 1;
        }
    }
}
