using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnController : MonoBehaviour
{
    public GameObject playerCheese;
    Vector3 playerCheesePos;
    public GameObject olivePrefab;
    public GameObject[] items;
    void Start()
    {
        playerCheesePos = new Vector3(1, 1, 0);
        Instantiate(playerCheese, playerCheesePos, Quaternion.identity);

        for (int j=0; j < 8; j++)
            {
                for(int k = 0; k < 4; k++)
                {
                    Vector3 matRand = new Vector3(j, 0, k);
                    Instantiate(olivePrefab, matRand, Quaternion.identity);
             

                }
        }
            //Vector3 randPos = new Vector3(Random.Range(-4, 4), 0, Random.Range(-3, 3));
           
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
