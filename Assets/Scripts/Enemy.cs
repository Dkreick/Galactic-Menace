using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Sprite primarySprite;
    private Sprite secondarySprite;
    public int health;

    void Start()
    {
        int randomNumber = Random.Range(0, 4);
        primarySprite = SpriteAtlas.dictSprites["enemy" + randomNumber + "_0"];
        secondarySprite = SpriteAtlas.dictSprites["enemy" + randomNumber + "_1"];
        GetComponent<Image>().sprite = primarySprite;
        InvokeRepeating("ChangeSprite", 1, 1);
    }

    void ChangeSprite()
    {
        if (GetComponent<Image>().sprite == primarySprite)
        {
            GetComponent<Image>().sprite = secondarySprite;
        }
        else
        {
            GetComponent<Image>().sprite = primarySprite;
        }
    }

    void TakeDamage()
    {
        health -= 1;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
