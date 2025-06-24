using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShipMovement : MonoBehaviour
{
    public float speed = 1f;
    public float leftandRightEdge = .5f;
    public float randomnes = 0.1f;
    public int colorChange = 0;
    public float timesForAppleDrops = 10f;
    public GameObject BULLETPrefab;
    public GameObject BULLETSoundEffect;
    public int TIMERSHOT;
    // Start is called before the first frame update

    void Start()
    {
        Invoke("ShipFire", 2f);
    }
    void ShipFire()
    {

            GameObject AlienShot = Instantiate<GameObject>(BULLETPrefab);
            AlienShot.transform.position = transform.position;
        GameObject AlienShotsound = Instantiate<GameObject>(BULLETSoundEffect);

    }
    void Update()
    {
        
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.y < -leftandRightEdge)
        {
            speed = Mathf.Abs(speed);//move right
        }
        else if (pos.y > leftandRightEdge)
        {
            speed = -Mathf.Abs(speed); //move left
        }
    }

    void FixedUpdate()
    {
        float randomShotTime = Random.Range(100, 300);
        TIMERSHOT += 2;
        if (TIMERSHOT > randomShotTime)
        {
            ShipFire();
            TIMERSHOT = 0;
        }
        if (Random.value < randomnes)
        {
            speed *= -1;
        }
    }
}
