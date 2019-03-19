﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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

/*     void OnCollisionEnter (Collision2D col)
    {
        Debug.Log("CHOCO!");
        Destroy(col.gameObject);
    } */

    void Move()
    {
        position.y += speed;
        this.transform.position = position;

        if (transform.position.y > 400)
        {
            Destroy(gameObject);
        }
    }
}
