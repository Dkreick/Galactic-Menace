using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Sprite primarySprite;
    private Sprite secondarySprite;
    public int health;
    private int randomNumber;

    void Start()
    {
        randomNumber = Random.Range(0, 4);
        primarySprite = SpriteAtlas.dictSprites["enemy" + randomNumber + "_0"];
        secondarySprite = SpriteAtlas.dictSprites["enemy" + randomNumber + "_1"];
        GetComponent<Image>().sprite = primarySprite;
        InvokeRepeating("ChangeSprite", 1, 1);
        AssignHealth(randomNumber);
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

    void OnTriggerEnter2D(Collider2D col) 
    { 
        health -= 1;
        if (health == 0)
        {
            Destroy(gameObject);
            GetComponent<Image>().sprite = SpriteAtlas.dictSprites["impact" + randomNumber];
            Destroy(GetComponent<BoxCollider2D>());
        }

        CalculateAdyacentEnemy();
    }

    void CalculateAdyacentEnemy() {
        // TODO
    }

    void AssignHealth(int number)
    {
        switch (number)
        {
            case 0:
            case 2:
                health = 1;
                break;

            case 1:
            case 3:
                health = 2;
                break;
        }
    }
}
