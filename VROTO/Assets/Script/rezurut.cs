﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 追加しましょう



public class rezurut : MonoBehaviour
{
    public GameObject score_object = null; //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score : " + ScoreManager.Score;

    }
}
