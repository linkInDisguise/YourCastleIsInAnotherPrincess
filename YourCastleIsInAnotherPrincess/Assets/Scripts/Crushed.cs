using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crushed : MonoBehaviour
{
    Vector3 originalPosition;
    public Animator anim;
    public GameObject Warning;
    GameObject tmpObj = null;
    public AudioSource[] source;

    void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        source = GetComponents<AudioSource>();
    }

    void update()
    {
        //Vec2 pos = new Vec2(gameObject.transform.position.x, 7);
        
        if (gameObject.transform.position.y == 15)
        {
           tmpObj = Instantiate(Warning, new Vector3(gameObject.transform.position.x, 0, 0), Quaternion.identity);
        }
        else if (7 < gameObject.transform.position.y && gameObject.transform.position.y < 15)
        {
            tmpObj.transform.position = new Vector3(gameObject.transform.position.x, 0, 0);
        }
        else if (gameObject.transform.position.y == 7)
        {
            DestroyImmediate(tmpObj);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        { 
            anim.SetBool("isDead", true);
            source[1].Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            source[0].Play();
            gameObject.transform.position = originalPosition;
        }
    }
}