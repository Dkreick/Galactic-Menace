using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private Vector3 position;
    public GameObject livesCount;
    private int lives;

    void Start()
    {
        speed = 1.5f;
        lives = 3;
        position = this.transform.position;
    }

    void Update()
    {
        Move();
        Shoot();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "EnemyBullet(Clone)")
        {
            lives--;
            livesCount.GetComponent<Text>().text = "X " + lives;
            this.transform.position = new Vector3(0, -300, 0);
            if (lives == 0)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
            }
            else
            {
                Time.timeScale = 0f;
            }
        }
        //CLAMPS
        if (this.transform.position.x < -65)
        {
            this.transform.position = this.transform.position;
        }
        if (this.transform.position.x > 65)
        {
            this.transform.position = this.transform.position;
        }
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject))) as GameObject;
            bullet.transform.SetParent(gameObject.transform);
            bullet.transform.position = gameObject.transform.position;
            bullet.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
