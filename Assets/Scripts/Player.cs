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
        MovePlayer();
    }

    void MovePlayer()
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
        //CLAMPS
        if (this.transform.position.x < -65)  {
            this.transform.position = this.transform.position;
        }
        if (this.transform.position.x > 65)  {
            this.transform.position = this.transform.position;
        }
    }
}
