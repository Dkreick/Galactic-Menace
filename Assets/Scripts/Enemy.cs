using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Sprite primarySprite;
    private Sprite secondarySprite;

    void Start()
    {
        Debug.Log((int)Random.Range(0, 4));
    }

    void Update()
    {
        ChangeSprite();
        Move();
    }

    void ChangeSprite()
    {

    }

    void Move()
    {

    }
}
