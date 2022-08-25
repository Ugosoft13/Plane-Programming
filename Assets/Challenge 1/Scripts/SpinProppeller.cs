﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinProppeller : MonoBehaviour
{
    public float propellerSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime );
    }
}
