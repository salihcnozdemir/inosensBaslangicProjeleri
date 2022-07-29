using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        transform.rotation = Quaternion.Euler(0,150,90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
