using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySoundEffect : MonoBehaviour
{
    public GameObject ZELF;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(ZELF, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
