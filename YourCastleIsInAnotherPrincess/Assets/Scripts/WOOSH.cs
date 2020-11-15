using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOOSH : MonoBehaviour
{
    private Rigidbody2D _rgbd;
    public int force;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
               
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        source.Play();
        _rgbd = col.gameObject.GetComponent<Rigidbody2D>();
        _rgbd.AddForce(new Vector2(0.0f, force));
    }
}
