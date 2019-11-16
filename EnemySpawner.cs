using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour {

    //public float movingSpeed;
    //private Vector3 moveDirection;
    private float timeBetween;
    public GameObject EnemyObj;
    //public GameObject EnemyStart;
    public float beginSpawnTime;
    public float spawnRate;

    // Use this for initialization
    void Start ()
    {
        timeBetween = 0f;
        //Invoke("FireEnemyBullet", 2f);

        //InvokeRepeating("IncreaseSpawnRates", 0f, 20f);

        Invoke("Spawn", beginSpawnTime);
    }

    void Spawn()
    {
        if (BackgroundManager.Instance.enemyspwn.activeInHierarchy)
        {
            Vector3 min = Camera.main.ViewportToWorldPoint(Vector3.zero); //left
            Vector3 max = Camera.main.ViewportToWorldPoint(Vector3.one); //right
                                                                         // instantiate/spawn enemies

            Vector3 spawnPos = new Vector3(Random.Range(min.x, max.x), max.y, 0f);
            GameObject enemy = (GameObject)Instantiate(EnemyObj, spawnPos, Quaternion.identity);

            /*GameObject bullet2 = (GameObject)Instantiate(BulletObj);
            bullet2.transform.position = BulletStart01.transform.position; */

            //delay for spawning
            timeBetween = spawnRate;
            Invoke("Spawn", timeBetween);
            Debug.Log("Spawn a new guy");
        }
    }
}
