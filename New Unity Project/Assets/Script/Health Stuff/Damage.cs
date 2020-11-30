using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    private int Health = 3;
    [SerializeField] Text hitText;
    
    void Update()
    {
        if (transform.position.y <= -7)
        {
            Dead();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Hit();
        }

        if (collision.gameObject.tag == "Wall")
        {
            Hit();

            if (Health == 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
            } 
        }
    }

    protected void Hit()
    {
        Health--;
        Debug.Log(Health);
        hitText.text = "HP:" + " " + Health.ToString();
    }
    void Dead()
    {
        Debug.Log("Test");
        transform.position = new Vector3(-10, -1.461544f, 0);
    }
}
