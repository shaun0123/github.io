﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            this.transform.Translate(0.0f, 0.0f, 0.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            this.transform.Translate(0.0f, 0.0f, -0.5f);
        }
    }
}
