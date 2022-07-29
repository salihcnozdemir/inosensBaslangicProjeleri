using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform pos;
    int enemyValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bird")
        {
            enemyValue = PlayerPrefs.GetInt("EnmyVlue");
            PlayerPrefs.SetInt("EnmyVlue", enemyValue-=1);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
       

        RaycastHit2D hit = Physics2D.Raycast(pos.transform.position, pos.transform.up, 0.1f);

        if (hit.collider != null)
        {
            Debug.Log("Target name: " + hit.collider.name);
            if (hit.collider.gameObject.tag == "obstacles")
            {
                enemyValue = PlayerPrefs.GetInt("EnmyVlue");
                PlayerPrefs.SetInt("EnmyVlue", enemyValue -= 1);
                Destroy(gameObject);
            }
        }
       
    }
}
