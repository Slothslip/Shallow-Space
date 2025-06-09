using UnityEngine;


public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 20f;
    public GameObject EnergyCharge;

    void Start()
    {

        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        GameObject collidedWith = other.gameObject;
        float random = Random.Range(0, 100);
        if (collidedWith.tag == "AstroidBasic")
        {
            Destroy(other.gameObject);
            //Vector3 spawnPos = transform.position + new Vector3(0f, 0f, 0f);
            //Instantiate(EnergyCharge, spawnPos, Quaternion.identity);
        }

    }
}
