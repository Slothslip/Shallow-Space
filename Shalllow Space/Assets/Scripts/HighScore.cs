using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text =  PlayerPrefs.GetInt("score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
