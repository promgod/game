﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoree : MonoBehaviour
{
    public int score = 0;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score = "+ score;
    }
    void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.CompareTag ("Player") )
        {
            score = score + 1;
        }
    }
}
