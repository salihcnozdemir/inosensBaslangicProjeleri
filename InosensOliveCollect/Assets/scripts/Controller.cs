using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject olivePrefab;
    public GameObject bananaPrefab;
    public GameObject oliveBoxPrefab;
    void Start()
    {
        
        for (int i = 0; i < 32; i++)
        {
            Vector3 randPos = new Vector3(Random.Range(-4, 4), 0, Random.Range(-3, 3));
            Instantiate(olivePrefab, randPos,Quaternion.identity);
        }
        Vector3 randPosCheese = new Vector3(Random.Range(-4, 4), 0, Random.Range(-3, 3));
        Instantiate(bananaPrefab, randPosCheese, Quaternion.identity);
        Vector3 randPosBox = new Vector3(Random.Range(-4, 4), 0, Random.Range(-3, 3));
        Instantiate(oliveBoxPrefab, randPosBox, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
