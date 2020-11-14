using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
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
            _rgbd.position += new Vector2(10.0f, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rgbd.position += new Vector2(-10.0f, 0.0f) * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
<<<<<<< HEAD
            _rgbd.AddForce(new Vector2(0.0f, 1500.0f));
=======
            isJumping = true;
            _rgbd.AddForce(new Vector2(0.0f, 400.0f));
>>>>>>> e5eb69b... Movement angepasst
        }
    }
}