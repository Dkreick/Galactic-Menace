using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Sprite primarySprite;
    private Sprite secondarySprite;
    public int health;
    public int enemyCode;
    public GameObject scoreCount;

    void Start()
    {
        enemyCode = Random.Range(0, 5);
        primarySprite = SpriteAtlas.dictSprites["enemy" + enemyCode + "_0"];
        secondarySprite = SpriteAtlas.dictSprites["enemy" + enemyCode + "_1"];
        GetComponent<Image>().sprite = primarySprite;
        InvokeRepeating("ChangeSprite", 1, 1);
        AssignHealth(enemyCode);
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
        if (col.gameObject.name == "Bullet(Clone)")
        {
            health -= 1;
            if (health == 0)
            {
                DisposeEnemy();
            }
            GetComponentInParent<Enemies>().CalculateAdyacentEnemy();
        }
    }

    public void DisposeEnemy()
    {
        SpriteAtlas.score++;
        scoreCount.GetComponent<Text>().text = "SCORE: " + SpriteAtlas.score;
        CancelInvoke();
        GetComponent<Image>().sprite = SpriteAtlas.dictSprites["impact" + enemyCode];
        Destroy(GetComponent<BoxCollider2D>());
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
