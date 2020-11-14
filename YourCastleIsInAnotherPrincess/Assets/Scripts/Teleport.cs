using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
     private new Rigidbody2D _rgbd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        _rgbd = col.gameObject.GetComponent<Rigidbody2D>();
        _rgbd.position = new Vector3(184.6f, 63.0f, 0.0f);
    }
}
