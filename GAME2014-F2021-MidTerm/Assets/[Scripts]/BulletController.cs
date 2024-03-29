﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*=================================================================
 * BulletController
 * Student: Lucas Krespi dos Santos, 
 * ID: 101289546
 * Date last Modified: 18/101/2021
 * check logic and change variable names;
 * change logic to portrait mode;
====================================================================
*/
public class BulletController : MonoBehaviour, IApplyDamage
{
    public float HorizontalSpeed;
    public float HorizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(HorizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > HorizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
