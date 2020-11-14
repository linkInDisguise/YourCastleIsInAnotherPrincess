using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOOSH : MonoBehaviour
{
    private Rigidbody2D _rgbd;
    public int force;
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
        _rgbd.AddForce(new Vector2(0.0f, force));
    }
}
