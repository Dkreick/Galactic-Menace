using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 position;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        MoveUpwards();
    }

    void MoveUpwards()
    {
        position.y += speed;
        this.transform.position = position;

        if(transform.position.y > 400) {
            Destroy(gameObject);
        }
    }
}
