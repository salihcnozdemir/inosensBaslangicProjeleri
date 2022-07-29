using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rig;
    public float flyPower;
    public Text textScore;
    int ScoreValue;
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        rig = GetComponent<Rigidbody2D>();
        Score();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
            SceneManager.LoadScene(0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            ScoreValue++;
            Score();
        }
           
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            StartCoroutine(ExampleCoroutine());

            rig.velocity = Vector2.zero;
            rig.velocity = Vector2.up * flyPower;

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60);
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0.4f);
        }
    }
    void Score()
    {
        textScore.text = "Score : " + ScoreValue;
    }
    IEnumerator ExampleCoroutine()
    {
        anim.SetBool("fly", true);
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("fly", false);
    }
}
