using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruits : MonoBehaviour
{
    public int ID;
    public GameObject fruitPrefab;
    public string name;
    void Start()
    {
        ID = Random.Range(0, 100);

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == name)
        {
            if (collision.transform.TryGetComponent(out fruits id))
            { // collided w/ enemy

                int Gid = id.ID;
                if (ID > Gid)
                    Instantiate(fruitPrefab, transform.position, Quaternion.identity);
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
