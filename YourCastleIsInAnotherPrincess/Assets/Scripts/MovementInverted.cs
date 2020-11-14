﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInverted : MonoBehaviour
{
    private Rigidbody2D _rgbd = null;
    public bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        _rgbd = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (isJumping == false)
            {
                _rgbd.position += new Vector2(-10.0f, 0.0f) * Time.deltaTime;
            }
            else
            {
                _rgbd.position += new Vector2(-6.0f, 0.0f) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (isJumping == false)
            {
                _rgbd.position += new Vector2(10.0f, 0.0f) * Time.deltaTime;
            }
            else
            {
                _rgbd.position += new Vector2(6.0f, 0.0f) * Time.deltaTime;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            _rgbd.AddForce(new Vector2(0.0f, 400.0f));
        }
    }
}