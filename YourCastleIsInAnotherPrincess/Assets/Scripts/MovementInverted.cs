using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInverted : MonoBehaviour
{
    private Rigidbody2D _rgbd = null;
    SpriteRenderer _SpriteRenderer = null;
    public Animator animator;
    public bool isJumping = false;
    private AudioSource source;
    
    float horizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _rgbd = GetComponent<Rigidbody2D>();
        _SpriteRenderer = GetComponent<SpriteRenderer>();
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isJumping = false;
        animator.SetBool("IsJumping", false);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _SpriteRenderer.flipX = true;
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
            _SpriteRenderer.flipX = false;
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
            source.Play();
            isJumping = true;
            animator.SetBool("IsJumping", true);
            _rgbd.AddForce(new Vector2(0.0f, 400.0f));
            
        }
    }
}