using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftTreeFruitSpawn : MonoBehaviour
{
    public GameObject[] furit;
    private GameObject currentFurit;
    int index;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        index = Random.Range(0,furit.Length);
        currentFurit = furit[index];
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range (6.40f,15.6f);
            whereToSpawn = new Vector2 (randX,transform.position.y);
            Instantiate (currentFurit,whereToSpawn,Quaternion.identity);        }
    }
}
