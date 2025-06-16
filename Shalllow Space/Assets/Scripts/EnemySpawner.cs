using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Astroid; // object that falls from the sky
    public GameObject AstroidT;
    public GameObject AstroidTT;
    public GameObject AstoidMetal;
    public GameObject AstroidFast;

    public float speed;

    private float ElapsedTime = 0f;
    public float TimeForSpawn;
    void Start()
    {
        TimeForSpawn = Random.Range(.5f, .8f);
        //speed= Random.Range(.5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > TimeForSpawn)
        {
            speed = Random.Range(.5f, 10f);
            float randomDb = Random.Range(1, 4);
            float randomRx = Random.Range(11, 14);
            float randomRz = Random.Range(10, -6);
            if (randomDb == 1)
            {
                GameObject AstroidZ = Instantiate<GameObject>(Astroid);
                Vector3 pos = new Vector2(randomRx, randomRz);
                Astroid.transform.position = pos;
            }
            else if (randomDb == 2)
            {
                GameObject AstroidTZ = Instantiate<GameObject>(AstroidT);
                Vector3 pos = new Vector2(randomRx, randomRz);
                AstroidT.transform.position = pos;
            }
            else if (randomDb == 3)
            {
                GameObject AstroidTTZ = Instantiate<GameObject>(AstroidTT);
                Vector3 pos = new Vector2(randomRx, randomRz);
                AstroidTTZ.transform.position = pos;
            }
            ElapsedTime = 0;
            print("Spawned");
        }
    }
}
