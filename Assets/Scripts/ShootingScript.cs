﻿using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    void Start()
    {
        // math to perfectly spawn bullets in front of us
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }


    public void Shoot()
    {
        float CurrentTime = Time.time;
        // bullet delay
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
            Instantiate(bullet, spawnPosition, transform.rotation);
            lastFiredTime = CurrentTime;
        }
    }
}
