using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesController : MonoBehaviour
{
    public GameObject pipePrefab;
    void Start()
    {
        InvokeRepeating("pipeAdd", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void pipeAdd()
    {
        GameObject pipe = Instantiate(pipePrefab);
    }
}
