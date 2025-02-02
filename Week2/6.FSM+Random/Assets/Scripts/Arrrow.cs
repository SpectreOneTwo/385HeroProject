﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrrow : MonoBehaviour
{
    const float kSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Arrow: Started");
    }

    // Update is called once per frame
    void Update()
    {
        // Vertical: Up/Down-Arrow, or WS-keys
        transform.position += Input.GetAxis("Vertical") * transform.up *
                                    (kSpeed * Time.smoothDeltaTime);
        // Horizontal: Left/Right-Arrow, or AD-Keys
        transform.position += Input.GetAxis("Horizontal") * transform.right *
                                    (kSpeed * Time.smoothDeltaTime);
    }
}
