using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int ID = 101;
    public GameObject fruitPrefab;
    public string name;
    public GameObject panel;
    void Start()
    {
     

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == name)
        {
            if (collision.transform.TryGetComponent(out fruits id))
            { // collided w/ enemy

                int Gid = id.ID;
                if (ID > Gid)
                {
                    Instantiate(fruitPrefab, transform.position, Quaternion.identity);
                    Instantiate(panel, transform.position, Quaternion.identity);
                }
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
