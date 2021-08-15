using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject[] bomb;
    public float xBound, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(2, 4));

        int randomFruit = Random.Range(0, fruits.Length);
        int randomBomb = Random.Range(0, bomb.Length);

        if (Random.value <= .6f)
        {
            Instantiate(fruits[randomFruit],
                new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        }
        else
        {
            Instantiate(bomb[randomBomb],
                new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomGameObject());
    }


}
