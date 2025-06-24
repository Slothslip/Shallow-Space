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
    public GameObject BossOne;

    public int BossCount; // spawns if above zero

    public GameObject LifeUpgrade;
    public GameObject SheildUpgrade;
    public GameObject SheildUpgradethree;
    public GameObject DoubleShotUpgrade;
    public GameObject TripleShotUpgrade;
    public GameObject BeemShotUpgrade;

    public float speed;

    private float ElapsedTime = 0f;
    public float TimeForSpawn;

    public int WaveNumber;
    public int AstroidCount;
    void Start()
    {
        BossCount = 1;
        TimeForSpawn = Random.Range(.5f, .8f);
        //speed= Random.Range(.5f, 10f);
        WaveNumber = 1;
        AstroidCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (AstroidCount == 25)
        {
            WaveNumber = 2;
        }
        else if (AstroidCount == 60)
        {
            WaveNumber = 3;
        }
        else if (AstroidCount == 120)
        {
            WaveNumber = 4;
        }
        else if (AstroidCount == 200) //
        {
            WaveNumber = 6;
            Time.timeScale = 1.5f;
        }
        if (ElapsedTime > TimeForSpawn)
        {
            speed = Random.Range(.5f, 10f);
            float randomDb = Random.Range(1, 7);
            float randomRx = Random.Range(11, 14);
            float randomRz = Random.Range(10, -6);
            if (randomDb == 1 && WaveNumber != 4)
            {
                GameObject AstroidZ = Instantiate<GameObject>(Astroid);
                Vector3 pos = new Vector2(randomRx, randomRz);
                Astroid.transform.position = pos;
                AstroidCount += 1;

            }
            else if (randomDb == 2 && WaveNumber != 4)
            {
                GameObject AstroidTZ = Instantiate<GameObject>(AstroidT);
                Vector3 pos = new Vector2(randomRx, randomRz);
                AstroidT.transform.position = pos;
                AstroidCount += 1;
            }
            else if (randomDb == 3 && WaveNumber != 4)
            {
                GameObject AstroidTTZ = Instantiate<GameObject>(AstroidTT);
                Vector3 pos = new Vector2(randomRx, randomRz);
                AstroidTTZ.transform.position = pos;
                AstroidCount += 1;
            }
            else if (randomDb == 4 && WaveNumber >= 2 && WaveNumber != 4)
            {
                GameObject AstoidMetalZ = Instantiate<GameObject>(AstoidMetal);
                Vector3 pos = new Vector2(randomRx, randomRz);
                AstoidMetalZ.transform.position = pos;
                AstroidCount += 1;
            }
            else if (randomDb == 5 && WaveNumber >= 3 && WaveNumber != 4)
            {
                GameObject AstroidFastZ = Instantiate<GameObject>(AstroidFast);
                Vector3 pos = new Vector2(randomRx, randomRz);
                AstroidFastZ.transform.position = pos;
                AstroidCount += 1;
            }
            else if ( WaveNumber >= 4 && BossCount == 1)
            {
                BossCount = 0;
                GameObject BossOneZ = Instantiate<GameObject>(BossOne);
                Vector3 pos = new Vector2(7, 0);
                BossOneZ.transform.position = pos;
                AstroidCount += 1;
            }
            ElapsedTime = 0;
            float randomUpgrade = Random.Range(1, 7);
            if (AstroidCount == 30 || AstroidCount == 70 || AstroidCount == 110 || AstroidCount == 140)
            {
                AstroidCount += 1;
                print("Upgrade spawned");
                if(randomUpgrade== 1)
                {
                    GameObject LifeUpgradeZ = Instantiate<GameObject>(LifeUpgrade);
                    Vector3 pos = new Vector2(randomRx, 0);
                    LifeUpgradeZ.transform.position = pos;
                }
                else if (randomUpgrade == 2)
                {
                    GameObject SheildUpgradeZ = Instantiate<GameObject>(SheildUpgrade);
                    Vector3 pos = new Vector2(randomRx, 0);
                    SheildUpgradeZ.transform.position = pos;
                }
                else if (randomUpgrade == 3)
                {
                    GameObject SheildUpgradethreeZ = Instantiate<GameObject>(SheildUpgradethree);
                    Vector3 pos = new Vector2(randomRx, 0);
                    SheildUpgradethreeZ.transform.position = pos;
                }
                else if (randomUpgrade == 4)
                {
                    GameObject DoubleShotUpgradeZ = Instantiate<GameObject>(DoubleShotUpgrade);
                    Vector3 pos = new Vector2(randomRx, 0);
                    DoubleShotUpgradeZ.transform.position = pos;
                }
                else if (randomUpgrade == 5)
                {
                    GameObject TripleShotUpgradeZ = Instantiate<GameObject>(TripleShotUpgrade);
                    Vector3 pos = new Vector2(randomRx, 0);
                    TripleShotUpgradeZ.transform.position = pos;
                }
                else if (randomUpgrade == 6)
                {
                    GameObject BeemShotUpgradeZ = Instantiate<GameObject>(BeemShotUpgrade);
                    Vector3 pos = new Vector2(randomRx, 0);
                    BeemShotUpgradeZ.transform.position = pos;
                }
            }
        }
    }
}
