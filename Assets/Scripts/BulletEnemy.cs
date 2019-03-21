using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float random;

    void Start()
    {
        random = Random.Range(1f, 3f);
        Invoke("Shoot", random);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(Resources.Load("EnemyBullet", typeof(GameObject))) as GameObject;
        bullet.transform.SetParent(GameObject.Find("Canvas").transform);
        bullet.transform.position = gameObject.transform.position;
        bullet.transform.localScale = new Vector3(1, 1, 1);
        random = Random.Range(1, 3);
        Invoke("Shoot", random);
    }
}
