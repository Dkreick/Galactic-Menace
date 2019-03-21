using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
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
        position.y -= speed;
        this.transform.position = position;

        if (transform.position.y < -100)
        {
            Destroy(gameObject);
        }
    }
}
