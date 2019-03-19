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
        int randomNumber = Random.Range(0, 4);
        primarySprite = SpriteAtlas.dictSprites["enemy" + randomNumber + "_0"];
        secondarySprite = SpriteAtlas.dictSprites["enemy" + randomNumber + "_1"];
        GetComponent<Image>().sprite = primarySprite;
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
