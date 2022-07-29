using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemies : MonoBehaviour
{
    public int enemyValue;
    public GameObject panel;
    public Text evText;
    void Start()
    {
        PlayerPrefs.SetInt("EnmyVlue", enemyValue);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyValue = PlayerPrefs.GetInt("EnmyVlue");
        evText.text = "Klan düþman sayýsý : " + enemyValue;
        if (enemyValue <= 0)
        {
            panel.SetActive(true);
            print("BÝTTÝ");
        }
    }
}
