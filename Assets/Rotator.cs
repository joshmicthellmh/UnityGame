﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

     void Update()
    {
        //Rotating script
        transform.Rotate(Vector3.right * speed * Time.deltaTime);    
    }
}
