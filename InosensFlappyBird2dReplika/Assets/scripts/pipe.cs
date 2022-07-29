using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    
    void Start()
    {
        float rnd = Random.Range(-1.42f, -0.24f);
        transform.position = new Vector3(3.4f, rnd, transform.position.z);
    }
   
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -3.5f)
        {
            Destroy(gameObject);
        }
        transform.Translate(-1.2f *Time.deltaTime, 0, 0);
    }
}
