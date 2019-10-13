﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControledVelocity : MonoBehaviour{   
    [SerializeField]
    Vector3 v3force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    // Update is called once per frame
    void FixedUpdate(){
        if(Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3force;
        if(Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3force;
    }
}
