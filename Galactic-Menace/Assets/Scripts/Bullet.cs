using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 position;
    public float speed;

    void Start()
    {
        position = this.transform.position;
        transform.SetParent(GameObject.Find("Canvas").transform);
    }

    void Update()
    {
        Move();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name != "Player")
        {
            Destroy(gameObject);
        }
    }

    void Move()
    {
        position.y += speed;
        this.transform.position = position;

        if (transform.position.y > 700)
        {
            Destroy(gameObject);
        }
    }
}
