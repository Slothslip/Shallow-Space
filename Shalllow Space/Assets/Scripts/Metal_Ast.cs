using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal_Ast : MonoBehaviour
{
    public int Ast_lives;
    public GameObject Zelf;
    public GameObject ExploisionOne;
    public Score Sc;

    private Vector3 original_pos;
    public int MSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Ast_lives = 2;
        Sc = GameObject.Find("ScoreSystem").GetComponent<Score>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject collidedWith = other.gameObject;
        if (collidedWith.tag == "Bulllet" && Ast_lives > 1)
        {
            Ast_lives -= 1;
            print("HIT");
            Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
            rigidBody.velocity = new Vector2(-MSpeed, 0f);
            original_pos = this.transform.position;
        }
        else if (collidedWith.tag == "Bulllet" && Ast_lives <= 1)
        {
            Destroy(Zelf);
            print("Bang");
            Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
            Instantiate(ExploisionOne, spawnPos, Quaternion.identity);
            Sc.score += 3;
            print(Sc.score.ToString());
        }
    }
}
