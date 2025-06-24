using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AleinShip_Health : MonoBehaviour
{
    public int AleinHealth;
    public GameObject Zelf;
    public GameObject Explosion;

    public EnemySpawner ES;
    public Score Sc;
    // Start is called before the first frame update
    void Start()
    {
        AleinHealth = 100;
        ES = GameObject.Find("Enemy_spawner").GetComponent<EnemySpawner>();
        Sc = GameObject.Find("ScoreSystem").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject collidedWith = other.gameObject;
        if (collidedWith.tag == "Bulllet" && AleinHealth > 0)
        {
            print(AleinHealth);
            AleinHealth -= 7;
        }
        else if (AleinHealth < 1)
        {
            Destroy(Zelf);
            ES.WaveNumber = 5;
            Sc.score += 10;
            print(Sc.score.ToString());
            Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
            Instantiate(Explosion, spawnPos, Quaternion.identity);
        }

    }
}
