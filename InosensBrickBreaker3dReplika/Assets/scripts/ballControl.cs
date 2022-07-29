using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ballControl : MonoBehaviour
{
    public Text scoreText;
    int Score;
    int heart = 3;
    public Rigidbody ballRig;
    Vector3 startPosition;
    public Image heartImage;
    public Player ply;

    public float ballSpeed;
    void Start()
    {

        Restart();
        scoreRes();
    }

    void Restart()
    {
        ballRig.velocity = Vector3.zero;
        transform.position = ply.transform.position;
        ballRig.velocity = new Vector3(ballSpeed, 0, ballSpeed);//çapraz hareket için
        
        switch (heart)
        {
            case 3:
                heartImage.fillAmount =1;
                break;
            case 2:
                heartImage.fillAmount = 0.66f;
                break;
            case 1:
                heartImage.fillAmount = 0.33f;
                break;
            default:
                heartImage.fillAmount = 0;
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "brick")
        {
            Score += 5;
            scoreRes();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "rightWall")
        {
            ballRig.velocity = new Vector3(-ballSpeed, 0, ballRig.velocity.z);
        }
        if (collision.gameObject.tag == "leftWall")
        {
            ballRig.velocity = new Vector3(ballSpeed, 0, ballRig.velocity.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            heart--;
            if (heart > 0)
                Restart();
            else
                SceneManager.LoadScene("SampleScene");
           
          //  SceneManager.LoadScene("SampleScene");

        }
    }

    void scoreRes()
    {
        scoreText.text = "SCORE : " + Score + "  ";
    }
    void Update()
    {
        
    }
}
