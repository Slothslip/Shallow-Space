using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_boost : MonoBehaviour
{
    private Vector3 original_pos;
    public int MSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject collidedWith = other.gameObject;
        if (collidedWith.tag == "Bulllet")
        {

            Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
            rigidBody.velocity = new Vector2(-MSpeed, 0f);
            original_pos = this.transform.position;
        }
    }

    }
