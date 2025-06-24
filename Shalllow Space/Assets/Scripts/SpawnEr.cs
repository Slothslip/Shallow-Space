using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEr : MonoBehaviour
{
    public GameObject Star; // object that falls from the sky
    public GameObject StarT;
    public GameObject StarTT;

    private float ElapsedTime = 0f;
    public float TimeForSpawn = .5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > TimeForSpawn)
        {
            float randomDb = Random.Range(1, 4);
            float randomRx = Random.Range(3, -4);
            float randomRz = Random.Range(8, -6);
            if (randomDb == 1)
            {
                GameObject StarZ = Instantiate<GameObject>(Star);
                Vector3 pos = new Vector2(11f, randomRz);
                Star.transform.position = pos;
            }
            else if (randomDb == 2)
            {
                GameObject StarTZ = Instantiate<GameObject>(StarT);
                Vector3 pos = new Vector2(11f, randomRz);
                StarT.transform.position = pos;
            }
            else if (randomDb == 3)
            {
                GameObject StarTTZ = Instantiate<GameObject>(StarTT);
                Vector3 pos = new Vector2(11f, randomRz);
                StarTT.transform.position = pos;
            }
            ElapsedTime = 0;
        }
    }
}
