using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("score", score);
    }
}
//PlayerPrefs.SetInt("score", cleanScore);