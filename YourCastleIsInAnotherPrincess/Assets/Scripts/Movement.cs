using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rgbd = null;


    // Start is called before the first frame update
    void Start()
    {
        _rgbd = GetComponent<Rigidbody2D>();
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rgbd.AddForce(new Vector2(0.0f, 1500.0f));
        }
    }
}