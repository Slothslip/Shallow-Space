﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextmeshproUGI
using UnityEngine.SceneManagement;

public class ShipDriver : MonoBehaviour
{

    public int Lives;
    public TextMeshProUGUI LivesText;

    public GameObject Shield;
    public int SheildON = 0;

    public Transform PlayerSpawn;

    public GameObject explosionO;
    public GameObject ShieldDropSound;

    // Start is called before the first frame update
    public GameObject bulletPrefab; // bullet one 
    public float reloadTime = 0.1f;
    float elapsedTime = 0f;
    void Start()
    {
        Lives = 3;
        Shield.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LivesText.text = "Lives: " + Lives.ToString();
        float vval;
        float hval;
        vval = Input.GetAxis("Vertical");
        hval = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;

        pos.y += vval * 0.1f;
        pos.x += hval * 0.1f; // added a varable later to change speed 
        transform.position = pos;

        elapsedTime += Time.deltaTime;

        //shooting
        if (Input.GetButtonDown("Jump") )
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(1.6f, -.4f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            elapsedTime = 0f;
        }

    }

    public void FIREOne()
    {
        if (elapsedTime > reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(1.6f, -.4f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            elapsedTime = 0f;
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //Destroy(other.gameObject);
        //Destroy(gameObject);
        GameObject collidedWith = other.gameObject;
        float random = Random.Range(0, 100);
        if (collidedWith.tag == "AstroidBasic" || collidedWith.tag == "AstroidMetal")
        {
            Destroy(other.gameObject);
            if (Lives > 0 && SheildON <= 0)
            {
                Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
                Instantiate(explosionO, spawnPos, Quaternion.identity);
                gameObject.transform.position = PlayerSpawn.position;
                Shield.SetActive(true);
                SheildON = 1;
                Lives -= 1;
            }
            else if (SheildON > 0)
            {
                Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
                Instantiate(ShieldDropSound, spawnPos, Quaternion.identity);
                SheildON -= 1;
                if (SheildON == 0)
                {
                    Shield.SetActive(false);
                }
            }
            else if (Lives < 1)
            {
                SceneManager.LoadScene(2);
            }
  
            //Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
            //Instantiate(EnergyCharge, spawnPos, Quaternion.identity);
        }
        else if (collidedWith.tag == "Upgrade_Sheild")
        {
            Shield.SetActive(true);
            SheildON = 1;
            Destroy(other.gameObject);
        }
        else if (collidedWith.tag == "Upgrade_SheildThree")
        {
            Shield.SetActive(true);
            SheildON = 3;
            Destroy(other.gameObject);
        }
        else if (collidedWith.tag == "Upgrade_Life")
        {
            Lives += 1;
            Destroy(other.gameObject);
        }

    }

}
