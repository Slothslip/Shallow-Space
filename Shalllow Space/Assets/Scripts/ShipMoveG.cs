using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMoveG : MonoBehaviour
{
    private Vector3 original_pos;
    private bool Switch = true;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(5f, 0f);
        original_pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > 20)
        {
            if (Switch == true)
            {
                Vector3 add = new Vector3(0, -7f, 0);
                Switch = false;
                Vector3 pos = this.transform.position;
                pos += add;
                original_pos.y += add.y;
                this.transform.position = original_pos;
                print("Jump Back");
            }
            else if (Switch == false)
            {
                Vector3 add = new Vector3(0, -7f, 0);
                Switch = true;
                Vector3 pos = this.transform.position;
                pos += add;
                original_pos.y -= add.y;
                this.transform.position = original_pos;
                print("Jump Back");
            }
        }
    }

}
