using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oliveBox : MonoBehaviour
{
    public Text scoreText;
    int scoreValue = 0;
    public GameObject winPanel;
    void Start()
    {
        winPanel = GameObject.Find("Panel");
        winPanel.SetActive(false);
        scoreText = GameObject.Find("Text").GetComponent<Text>();

        scoreText.text = "Score : " + scoreValue;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "olive")
        {
            Destroy(other.gameObject);
            score();
        }
    }
    void Update()
    {
        if(scoreValue >=32)
        {
            winPanel.SetActive(true);
        }
      
    }
    void score()
    {
        scoreValue++;
        scoreText.text = "Score : " + scoreValue;
    }
}
