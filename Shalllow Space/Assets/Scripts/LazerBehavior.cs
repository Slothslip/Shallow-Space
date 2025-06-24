using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBehavior : MonoBehaviour
{
    public float speed = 10f;
    public GameObject Zelf;

    public GameObject ExploisionOne;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //Destroy(other.gameObject);
        //Destroy(gameObject);
        GameObject collidedWith = other.gameObject;
        float random = Random.Range(0, 100);
        if (collidedWith.tag == "AstroidBasic")
        {
            Destroy(other.gameObject);
            Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
            Instantiate(ExploisionOne, spawnPos, Quaternion.identity);
        }
    }
}
