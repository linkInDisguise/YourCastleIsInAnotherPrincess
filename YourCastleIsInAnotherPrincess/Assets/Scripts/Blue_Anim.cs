using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Walk : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetTrigger("Blue_Walk");
        }
    }
}
