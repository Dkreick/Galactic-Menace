using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    Vector3 position;
    public float speed;

    void Start()
    {
        position = this.transform.position;
    }

    void Update()
    {
        Move();
    }

    void OnCollisionEnter (Collision col)
    {
        Debug.Log("CHOCO!");
        Destroy(col.gameObject);
    }

    void Move()
    {
        position.y -= speed;
        this.transform.position = position;

        if (transform.position.y < -400)
        {
            Destroy(gameObject);
        }
    }
}
