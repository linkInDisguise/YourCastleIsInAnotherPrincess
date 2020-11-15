using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public Animator anim;
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
        if (col.gameObject.tag == "Player")
        {
            source.Play();
            anim.SetBool("isDead", true);//Use the length of the animation clip as the wait time for yield
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//reload the current level
        }
    }
}
