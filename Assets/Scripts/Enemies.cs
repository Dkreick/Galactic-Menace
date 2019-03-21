using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemies : MonoBehaviour
{
    GameObject[,] gridArray = new GameObject[4, 10];
    public int speed;
    private Vector3 position;

    void Start()
    {
        speed = 30;
        position = this.transform.position;
        CreateGrid();
        InvokeRepeating("MoveGrid", 1, 0.5f);
    }

    void CreateGrid()
    {
        for (int i = 0; i < gridArray.GetLength(0); i++)
        {
            for (int j = 0; j < gridArray.GetLength(1); j++)
            {
                GameObject go = Instantiate(Resources.Load("Enemy", typeof(GameObject)), new Vector3(j * 1.05f, i * 1.05f, 0), transform.rotation, transform) as GameObject;
                go.GetComponent<Image>().SetNativeSize();
                gridArray[i, j] = go;

                if (i == gridArray.GetLength(0) -1)
                {
                    go.AddComponent<BulletEnemy>();
                    Debug.Log("Agregame el tiro");
                }
            }
        }
    }

    void MoveGrid()
    {
        position.x += speed;
        this.transform.position = position;
        if (this.transform.position.x >= 692)
        {
            position.y -= speed;
            this.transform.position = position;
            speed = speed * -1;
        }
        if (this.transform.position.x <= 272)
        {
            position.y += speed;
            this.transform.position = position;
            speed = speed * -1;
        }
    }
}
