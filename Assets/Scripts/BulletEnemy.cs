using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("Shoot", 3, 3);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(Resources.Load("EnemyBullet", typeof(GameObject))) as GameObject;
        bullet.transform.SetParent(gameObject.transform);
        bullet.transform.position = gameObject.transform.position;
        bullet.transform.localScale = new Vector3(1, 1, 1);
    }
}
