using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDriver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab; // bullet one 
    public float reloadTime = 0.1f;
    float elapsedTime = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vval;
        float hval;
        vval = Input.GetAxis("Vertical");
        hval = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;

        pos.y += vval * 0.02f;
        pos.x += hval * 0.02f; // added a varable later to change speed 
        transform.position = pos;

        elapsedTime += Time.deltaTime;

        //shooting
        if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(1.6f, -.4f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            elapsedTime = 0f;
        }
    }
}
