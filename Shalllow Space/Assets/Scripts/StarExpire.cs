using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarExpire : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimetellDestroy = 20f;
    private float ElapsedTime = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > TimetellDestroy)
        {
            Destroy(gameObject);
            ElapsedTime = 0;
            //print("Star Go Boom");
        }
    }
}
