using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ast_move : MonoBehaviour
{
    private Vector3 original_pos;
    public int ASpeed;
    //private bool Switch = true;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(-ASpeed, 0f);
        original_pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
