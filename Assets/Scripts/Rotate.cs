﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    // SerializeField exposes this value to the Editor
    [SerializeField]
    private float maximumSpinSpeed = 200;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
