using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Vector3 position;
    
    void Start()
    {
        speed = 1.5f;
        position = this.transform.position;
    }

    void Update()
    {
        Move();
        Shoot();
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        
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
