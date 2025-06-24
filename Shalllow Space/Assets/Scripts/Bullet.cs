using UnityEngine;


public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 20f;
    public GameObject ExploisionOne;
    public Score Sc;
    public GameObject SoundEffect;

    void Start()
    {
        Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
        Instantiate(SoundEffect, spawnPos, Quaternion.identity);

        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(speed, 0);
        Sc = GameObject.Find("ScoreSystem").GetComponent<Score>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        //Destroy(other.gameObject);
        Destroy(gameObject);
        GameObject collidedWith = other.gameObject;
        float random = Random.Range(0, 100);
        if (collidedWith.tag == "AstroidBasic")
        {
            Destroy(other.gameObject);
            Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
            Instantiate(ExploisionOne, spawnPos, Quaternion.identity);
            Sc.score += 1;
            print(Sc.score.ToString());
        }
        else if (collidedWith.tag == "AstroidMetal")
        {
            Destroy(gameObject);
        }

    }
}
